using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.OkulForms;
=======
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
>>>>>>> yandal
using DPU_Soft.PlacementOfExams.UI.Win.Show.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DevExpress.XtraGrid.Views.Grid;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using DPU_Soft.BLL.Base.Interfaces;
<<<<<<< HEAD
=======
using DevExpress.XtraPrinting.Native;
using DevExpress.Utils.Extensions;
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/BaseForms/BaseListForm.cs
>>>>>>> yandal
=======
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.FiltreForms;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms;
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/BaseForms/BaseListForm.cs

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/BaseForms/BaseListForm.cs
<<<<<<< HEAD
=======
=======
        private long _filtreId;
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/BaseForms/BaseListForm.cs
        private bool _formSablonKayitEdilecek;
        private bool _tabloSablonKayitedilecek;
>>>>>>> yandal
        protected IBaseFormshow FormShow;
        protected KartTuru BaseKartTuru;
        protected internal GridView Tablo;
        protected bool AktifKartlariGoster=true;
<<<<<<< HEAD
=======
        protected internal bool AktifPasifButonGoster=false;
>>>>>>> yandal
        protected internal bool MultiSelect;
        protected internal BaseEntity SecilenEntity;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;
        protected internal long? SeciliGelecekId;
<<<<<<< HEAD
=======
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
>>>>>>> yandal

        public BaseListForm()
        {
            InitializeComponent();
         //   EventsLoad();
        }

        private void EventsLoad()
        {
            //Buton Events
            foreach (BarItem button in ribbonControl.Items)
            {
                        button.ItemClick += Button_ItemClick;
                
            }

            //Tablo Events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
<<<<<<< HEAD
            //Form Events
=======
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.ColumnWidthChanged += Tablo_ColumnWidthChanged;
            Tablo.ColumnPositionChanged += Tablo_ColumnPositionChanged;
            Tablo.EndSorting += Tablo_EndSorting;
            Tablo.FilterEditorCreated += Tablo_FilterEditorCreated;
            Tablo.ColumnFilterChanged += Tablo_ColumnFilterChanged;

            //Form Events
            Shown += BaseListForm_Shown;
            Load += BaseListForm_Load;
            FormClosing += BaseListForm_FormClosing;
            LocationChanged += BaseListForm_LocationChanged;
            SizeChanged += BaseListForm_SizeChanged;
        }

        private void Tablo_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tablo.ActiveFilterString))
                _filtreId = 0;
        }

        private void Tablo_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
        {
            e.ShowFilterEditor = false;
            ShowEditforms<FiltreEditForm>.ShowDialogeditForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);

        }

        private void BaseListForm_SizeChanged(object sender, EventArgs e)
        {
            if (!IsMdiChild)
                _formSablonKayitEdilecek = true;
        }

        private void BaseListForm_LocationChanged(object sender, EventArgs e)
        {
            if (!IsMdiChild)
                _formSablonKayitEdilecek = true;
        }

        private void Tablo_EndSorting(object sender, EventArgs e)
        {
            _tabloSablonKayitedilecek = true;
        }

        private void Tablo_ColumnPositionChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitedilecek = true;
        }

        private void Tablo_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            _tabloSablonKayitedilecek = true;
        }

        private void BaseListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }

        private void BaseListForm_Load(object sender, EventArgs e)
        {
            SablonYukle();
        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void BaseListForm_Shown(object sender, EventArgs e)
        {
            Tablo.Focus();
            ButtonGizleGoster();
          //  SutunGizleGoster();
            if (IsMdiChild || SeciliGelecekId == null) return;
            Tablo.RowFocus("Id",SeciliGelecekId);
        }

        private void ButtonGizleGoster()
        {
            
            btnSeç.Visibility = AktifPasifButonGoster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnter.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnterAciklama.Visibility=IsMdiChild?BarItemVisibility.Never: BarItemVisibility.Always;
            btnAktifPasifKartlar.Visibility=AktifPasifButonGoster? BarItemVisibility.Always: !IsMdiChild? BarItemVisibility.Never: BarItemVisibility.Always;

            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
            /* Yukarıdaki kodun aynısı foreach (BarItem item in ShowItems)
            {
                item.Visibility = BarItemVisibility.Always;
            }*/
        }

        private void SutunGizleGoster()
        {
           // throw new NotImplementedException();
        }

        private void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
                Name.FormSablonKaydet(Left,Top,Width, Height, WindowState);

            if (_tabloSablonKayitedilecek)
                Tablo.TabloSablonKaydet(IsMdiChild?Name+" Tablosu": Name+" TablosuMDI");
        }

        private void SablonYukle()
        {
            if (IsMdiChild)
                Tablo.TabloSablonYukle(Name+" Tablosu");
            else
            {
                Name.FormSablonYukle(this);
                Tablo.TabloSablonYukle(Name + " TablosuMDI");
            }
            
>>>>>>> yandal
        }

        protected internal void Yukle()
        {
            DegiskenleriDoldur();
            EventsLoad();

            Tablo.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Tablo.GridControl;
            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;

            //Güncellenecek
        }

        protected virtual void DegiskenleriDoldur()
        {

        }

        protected virtual void ShowEditForm(long id)
        {
            var result = FormShow.ShowDialogeditForm(BaseKartTuru, id);
<<<<<<< HEAD
        }

        private void EntityDelete()
        {
            throw new NotImplementedException();
=======
            ShowEditFormDefault(result);
        }

        protected void ShowEditFormDefault(long id)
        {
            if (id <= 0) return;
            AktifKartlariGoster = true;
            FormCaptionAyarla();
            Tablo.RowFocus("Id", id);
        }


        protected virtual void EntityDelete()
        {
            var entity = Tablo.GetRow<BaseEntity>();
            if (entity == null) return;
            if (!((IBaseCommonBll)Bll).Delete(entity)) return;

            Tablo.DeleteSelectedRows();
            Tablo.RowFocus(Tablo.FocusedRowHandle);
>>>>>>> yandal
        }

        private void SelectEntity()
        {
            if (MultiSelect)
            {
                //güncellenecek

            }
            else
            {
                SecilenEntity = Tablo.GetRow<BaseEntity>();
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        protected virtual void Listele()
        {
            
        }

        private void FiltreSec()
        {
            var entity = (FiltreEntity)ShowListforms<FiltreListForm>.ShowDialogListForm(KartTuru.Filtre,_filtreId,BaseKartTuru,Tablo.GridControl);
            if (entity == null) return;
            _filtreId = entity.Id;
            Tablo.ActiveFilterString = entity.FiltreMetni;
        }

        protected virtual void Yazdir()
        {
            TablePrintingFunctions.Yazdir(Tablo,Tablo.ViewCaption,AnaForm.FakulteAdi);
        }

        private void FormCaptionAyarla()
        {
<<<<<<< HEAD
            throw new NotImplementedException();
=======
            if (btnAktifPasifKartlar==null)
            {
                Listele();
                return;
            }

            if (AktifKartlariGoster==true)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                Tablo.ViewCaption = Text;

            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                Tablo.ViewCaption = Text + " - Pasif Kartlar";

            }
            Listele();
>>>>>>> yandal
        }

        private void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                //Güncelle
                SelectEntity();
            }
            else
                btnDuzelt.PerformClick();
        }
        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

<<<<<<< HEAD
            if (e.Item==btnGonder) 
=======
            if (e.Item == btnGonder)
>>>>>>> yandal
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
<<<<<<< HEAD
            else if (e.Item==btnStandartExcelDosyasi)
            {

            }

            else if (e.Item==btnFormatliExcelDosyasi)
            {

            }
            else if (e.Item == btnFormatsizExcelDosyasi)
            {

            }
            else if (e.Item == btnWordDosyasi)
            {

            }

            else if (e.Item == btnPdfDosyasi)
            {

            }
            else if (e.Item == btnTxtDosyasi)
            {

            }
=======
            else if (e.Item == btnStandartExcelDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.ExcelStandart,e.Item.Caption,Text);
            else if (e.Item == btnFormatliExcelDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.ExcelFormat, e.Item.Caption, Text);
            else if (e.Item == btnFormatsizExcelDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatsiz, e.Item.Caption, Text);
            else if (e.Item == btnWordDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.WordDosyasi, e.Item.Caption, Text);
            else if (e.Item == btnPdfDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.PdfDosyasi, e.Item.Caption, Text);
            else if (e.Item == btnTxtDosyasi)
                Tablo.TabloDisariAktar(DosyaTuru.TxtDosyasi, e.Item.Caption, Text);
>>>>>>> yandal
            else if (e.Item == btnYeni)
            {
                //Yetki Kontrolü
                ShowEditForm(-1);
            }
            else if (e.Item == btnDuzelt)
            {
                ShowEditForm(Tablo.GetRowId());
            }
<<<<<<< HEAD
            else if (e.Item== btnSil)
=======
            else if (e.Item == btnSil)
>>>>>>> yandal
            {
                //Yetki Kontrolü
                EntityDelete();
            }

<<<<<<< HEAD
            else if (e.Item==btnSeç)
=======
            else if (e.Item == btnSeç)
>>>>>>> yandal
            {
                SelectEntity();
            }

<<<<<<< HEAD
            else if (e.Item==btnYenile)
=======
            else if (e.Item == btnYenile)
>>>>>>> yandal
            {
                Listele();
            }

<<<<<<< HEAD
            else if (e.Item==btnFiltrele)
=======
            else if (e.Item == btnFiltrele)
>>>>>>> yandal
            {
                FiltreSec();
            }

<<<<<<< HEAD
            else if (e.Item==btnKolonlar)
=======
            else if (e.Item == btnKolonlar)
>>>>>>> yandal
            {
                if (Tablo.CustomizationForm == null)
                {
                    Tablo.ShowCustomization();
                }
                else Tablo.HideCustomization();
            }

<<<<<<< HEAD
            else if (e.Item==btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item==btnCikis)
=======
            else if (e.Item == btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item == btnCikis)
>>>>>>> yandal
            {
                Close();
            }

<<<<<<< HEAD
            else if (e.Item==btnAktifPasifKartlar)
=======
            else if (e.Item == btnAktifPasifKartlar)
>>>>>>> yandal
            {
                AktifKartlariGoster = !AktifKartlariGoster;
                FormCaptionAyarla();
            }
<<<<<<< HEAD
=======
            else if (e.Item == btnBagliKartlar)
            {
                BaglikartAc();
            }
>>>>>>> yandal

            Cursor.Current = DefaultCursor;
        }

<<<<<<< HEAD
=======
        protected virtual void BaglikartAc()
        {
            
        }

>>>>>>> yandal
        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }
                
        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    IslemTuruSec();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

    }
}