using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls;
using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using DevExpress.XtraPrinting.Native;
using DevExpress.Utils.Extensions;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        private bool _formSablonKayitedilecek;
        protected internal IslemTuru BaseIslemTuru;
        protected internal long Id;
        protected internal long SubeId;
        protected internal long DonemId;
        protected internal bool RefreshYapilacak;
        protected DpuDataLayoutControl DataLayoutControl;
        protected DpuDataLayoutControl[] DataLayoutControls;
        protected IBaseBll Bll;
        protected KartTuru BaseKartTuru;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected bool IsLoaded;
        protected bool KayitSonrasiFormuKapat = true;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        public BaseEditForm()
        {
            InitializeComponent();
        }
        public virtual void Yukle() 
        { 
                    
        }
        protected virtual void Giris()
        {

        }
        protected internal virtual IBaseEntity ReturnEntity()
        {
            return null;
        }
        protected void EventsLoad()
        {
            //button events
            foreach (BarItem item in ribbonControl.Items)
            {
                item.ItemClick += Buttom_ItemClick;
            }

            //form Events
            LocationChanged += BaseEditForm_LocationChanged;
            SizeChanged += BaseEditForm_SizeChanged;
            Load += BaseEditForm_Load;
            FormClosing += BaseEditForm_FormClosing;
            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;
                control.GotFocus += Control_GotFocus;
                control.Leave += Control_Leave;

                switch (control)
                {
                    case FilterControl edt:
                        edt.FilterChanged+= Control_EditValueChanged;
                        break;
                    case ComboBoxEdit edt:
                        edt.SelectedValueChanged += Control_SelectedValueChanged;
                        edt.EditValueChanged+= Control_EditValueChanged;
                        break;
                    case DpuButtonEdit edt:
                        edt.IdChanged += Control_IdChanged;
                        edt.EnabledChange += Control_EnabledChange;
                        edt.ButtonClick += Control_ButtonClick;
                        edt.DoubleClick += Control_DoubleClick;
                        break;
                    case BaseEdit edt:
                        edt.EditValueChanged += Control_EditValueChanged;
                        break;
                    case DpuGridControl grd:
                        grd.MainView.GotFocus += Control_GotFocus;
                        break;
                }

            }
            if (DataLayoutControls == null)
            {
                if (DataLayoutControl == null) return;
                foreach (Control ctrl in DataLayoutControl.Controls)
                    ControlEvents(ctrl);
            }
            else
                foreach (var layout in DataLayoutControls)
                    foreach (Control ctrl in layout.Controls)
                        ControlEvents(ctrl);
        }

        protected virtual void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            statusBarKisayol.Visibility = BarItemVisibility.Never;
            statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            var type = sender.GetType();

            if (type == typeof(DpuButtonEdit) || type == typeof(DpuGridView) || type == typeof(DpuPictureEdit) || type == typeof(DpuComboBoxEdit) || type == typeof(DpuDateedit))
            {
                statusBarKisayol.Visibility = BarItemVisibility.Always;
                statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

                statusBarAciklama.Caption = ((IStatusBarAciklama)sender).StatusBarAciklama;
                statusBarKisayol.Caption = ((IStatusBarKisayol)sender).StatusBarKisayol;
                statusBarKisayolAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarKisayolAciklama;

            }
            else if (sender is IStatusBarAciklama ctrl)
                statusBarAciklama.Caption = ctrl.StatusBarAciklama;
        }

        private void BaseEditForm_SizeChanged(object sender, EventArgs e)
        {
            _formSablonKayitedilecek = true;
        }

        private void BaseEditForm_LocationChanged(object sender, EventArgs e)
        {
            _formSablonKayitedilecek = true;
        }

        protected virtual void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
            if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;
            if (!Kaydet(true))
                e.Cancel = true;
        }

        protected virtual void FiltreUygula()
        {

        }

        protected void SablonKaydet()
        {
            if (_formSablonKayitedilecek)
                Name.FormSablonKaydet(Left,Top,Width,Height,WindowState);
            
        }

        private void SablonYukle()
        {
            Name.FormSablonYukle(this);
        }

        protected virtual void Control_EnabledChange(object sender, EventArgs e)
        {
            
        }

        private void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        protected virtual void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                Close();
            }
            if (sender is DpuButtonEdit edt)
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete when e.Control && e.Shift:
                        edt.Id = null;
                        edt.EditValue = null;
                        break;

                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        SecimYap(edt);
                        break;
 
                }
            }
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            GuncelNesneOlustur();
            SablonYukle();
            ButtonGizleGoster();
            //güncelleme Yap

        }

        protected virtual void Buttom_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item==btnYeni)
            {
                //Yetki Kontrolü
                BaseIslemTuru = IslemTuru.EntityInsert;
                Yukle();
            }
            else if (e.Item==btnKaydet)
            {
                Kaydet(false);
            }
            else if (e.Item==btnFarkliKaydet)
            {
                //Yetki kontrolü
                FarkliKaydet();
            }
            else if (e.Item==btnGeriAl)
            {
                GeriAl();
            }
            else if (e.Item==btnSil)
            {
                //Yetki Kontrolü
                EntityDelete();
            }
            else if (e.Item == btnUygula)
            {
                FiltreUygula();
            }
            else if (e.Item==btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item==btnBaskiOnizleme)
            {
                BaskiOnizleme();
            }
            else if (e.Item==btnSifreSifirla)
            {
                SifreSifirla();
            }
            else if (e.Item == btnExceldenAl)
            {
                ExcelAl();
            }
            else if (e.Item==btnGiris)
            {
                Giris();
            }
            else if (e.Item==btnCikis)
            {
                Close();
            }

            Cursor.Current = DefaultCursor;
        }

        protected virtual void ExcelAl()
        {

        }

        protected virtual void SifreSifirla()
        {
           
        }

        protected virtual void BaskiOnizleme()
        {
            
        }

        protected virtual void Yazdir()
        {
            
        }

        protected virtual void TabloYukle()
        {

        }

        private void FarkliKaydet()
        {
            if (Messages.EvetSeciliEvetHayir("Bu filtre referans alınarak yeni bir filtre oluşturulacaktır. Onaylıyor musunuz?", "Kayıt Onayı") != DialogResult.Yes) return;
            BaseIslemTuru = IslemTuru.EntityInsert;
            Yukle();
            if (Kaydet(true)) Close();
        }

        protected virtual void SecimYap(object sender)
        {
        }
        private void EntityDelete()
        {
            if (!((IBaseCommonBll)Bll).Delete(OldEntity)) return;
            RefreshYapilacak = true;
            Close();
        }

        private void ButtonGizleGoster()
        {

          
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
            /* Yukarıdaki kodun aynısı foreach (BarItem item in ShowItems)
            {
                item.Visibility = BarItemVisibility.Always;
            }*/
        }


        private void GeriAl()
        {
            if (Messages.HayirSeciliEvetHayir("Yapılan değişikler geri alınacaktır. Onaylıyor musunuz?", "Geri Al Onay") != DialogResult.Yes) return;
            if (BaseIslemTuru == IslemTuru.EntityUpdate)
                Yukle();
            else
                Close();
        }

        private bool Kaydet(bool kapanis)
        {
            bool KayitIslemi()
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (BaseIslemTuru)
                {
                    case IslemTuru.EntityInsert:
                        if (EntityInsert())
                            return KayitSonrasiIslemler();
                        break;
                    case IslemTuru.EntityUpdate:
                        if (EntityUpdate())
                            return KayitSonrasiIslemler();
                        break;
                }
                bool KayitSonrasiIslemler()
                {
                    OldEntity = CurrentEntity;
                    RefreshYapilacak = true;
                    ButtonEnabledDurumu();
                    if (KayitSonrasiFormuKapat)
                        Close();
                    else
                        BaseIslemTuru = BaseIslemTuru == IslemTuru.EntityInsert ? IslemTuru.EntityUpdate : BaseIslemTuru;
                    return true;

                }
                return false;
            }
            
            var result = kapanis ? Messages.KapanisMesaj() : Messages.KayitMesaj();
            switch (result)
            {
                case DialogResult.Yes:
                    return KayitIslemi();
                case DialogResult.No:
                    if (kapanis)
                    {
                        btnKaydet.Enabled = false;
                    }
                        return true;
                    
                case DialogResult.Cancel:
                    return false;

            }
            return false;
        }



        protected virtual bool EntityInsert()
        {
            return ((IBaseHareketSelectBll)Bll).Insert(CurrentEntity);
        }

        protected virtual bool EntityUpdate()
        {
            return ((IBaseHareketSelectBll)Bll).Update(OldEntity, CurrentEntity);
        }
        protected virtual void NesneyiKontrollereBagla()
        {

        }

        protected virtual void GuncelNesneOlustur()
        {

        }

        protected internal virtual void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni,btnKaydet,btnGeriAl,btnSil,OldEntity,CurrentEntity);
            
        }
    }
}