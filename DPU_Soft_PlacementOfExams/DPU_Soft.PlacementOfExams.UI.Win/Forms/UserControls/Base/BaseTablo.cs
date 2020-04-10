using DPU_Soft.BLL.Base.Interfaces;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars;
using DevExpress.Utils.Extensions;
using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System.Linq;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System.Collections.Generic;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Base
{
    public partial class BaseTablo : DevExpress.XtraEditors.XtraUserControl
    {
        private bool _isLoaded;
        private bool _tabloSablonKayitEdilecek;
        protected IBaseBll Bll;
        protected internal GridView Tablo;
        protected internal bool TablevalueChanged;
        protected internal BaseEditForm OvnerForm;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected internal IList<long> ListeDisiTutulacakKayitlar;

        public int BaseListForm_Shown { get; private set; }
        public int BaseListForm_FormClosing { get; private set; }

        public BaseTablo()
        {
            InitializeComponent();
        }


        protected void EventsLoad()
        {
            //Button Events

            foreach (BarItem item in barManager.Items)
                item.ItemClick += Button_ItemClick;

            //Navigator Events

            ınsUptNavigator.Navigator.ButtonClick += Navigator_ButtonClick;

            //Table Events
            Tablo.CellValueChanged += Tablo_CellValueChanged;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.GotFocus += Tablo_GotFocus;
            Tablo.LostFocus += Tablo_LostFocus;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.FocusedColumnChanged += Tablo_FocusedColumnChanged;
            Tablo.ColumnPositionChanged += Tablo_SablonChanged;
            Tablo.ColumnWidthChanged+= Tablo_SablonChanged;
            Tablo.EndSorting+= Tablo_SablonChanged;
            Tablo.FocusedRowObjectChanged += Tablo_FocusedRowObjectChanged;
            Tablo.DoubleClick += Tablo_DoubleClick;
        }



        protected internal void Yukle()
        {
            _isLoaded = true;
            TablevalueChanged = false;
            OvnerForm.ButtonEnabledDurumu();
            ınsUptNavigator.Navigator.NavigatableControl = Tablo.GridControl;
            SablonYukle();
            Listele();
            ButtonGizleGoster();
            Tablo_LostFocus(Tablo,EventArgs.Empty);
        }

        private void SablonKaydet()
        {
            if (_tabloSablonKayitEdilecek)
                Tablo.TabloSablonKaydet(Tablo.ViewCaption);
        }
        private void SablonYukle()
        {
            Tablo.TabloSablonYukle(Tablo.ViewCaption);
        }

        protected virtual void Listele()
        {
            
        }
        private void ButtonGizleGoster()
        {


            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);

        }

        protected virtual void HareketEkle()
        {
            
        }

        protected virtual void HareketSil()
        {
            if (Tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("İşlem Satırı") != DialogResult.Yes) return;
            Tablo.GetRow<IBaseHareketEntity>().Delete=true;
            Tablo.RefreshDataSource();
            ButonenableDurumu(true);
        }

        protected internal virtual bool HataliGiris() { return false; }

        protected virtual void OpenEntity() 
        {

        }

        protected void ButonenableDurumu(bool durum)
        {
            TablevalueChanged = durum;
            OvnerForm.ButtonEnabledDurumu();
            
        }

        protected internal bool Kaydet()
        {
            var source = Tablo.DataController.ListSource;

            var insert = source.Cast<IBaseHareketEntity>().Where(x => x.Insert && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var update = source.Cast<IBaseHareketEntity>().Where(x => x.Update && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var delete= source.Cast<IBaseHareketEntity>().Where(x => x.Delete && !x.Insert).Cast<BaseHareketEntity>().ToList();

            if (insert.Any())
                if (!((IBasehareketGenelBll)Bll).Insert(insert))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Eklenemedi");
                    return false;
                }
            if (update.Any())
                if (!((IBasehareketGenelBll)Bll).Update(update))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Güncellenemedi");
                    return false;
                }
            if (delete.Any())
                if (!((IBasehareketGenelBll)Bll).Delete(delete))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Silinemedi");
                    return false;
                }
            Listele();
            ButonenableDurumu(false);
            return true;
        }
        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnHareketEkle)
                HareketEkle();
            else if (e.Item == btnHareketSil)
                HareketSil();
            else if (e.Item == btnHareketDuzenle)
                OpenEntity();
            else if (e.Item==btnTabloYenile)
            {
                Listele();
            }
            Cursor.Current = Cursors.Default;
        }



        private void Navigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button == ınsUptNavigator.Navigator.Buttons.Append)
                HareketEkle();
            else if (e.Button == ınsUptNavigator.Navigator.Buttons.Remove)
                HareketSil();

            //if (e.Button == ınsUptNavigator.Navigator.Buttons.Append || e.Button == ınsUptNavigator.Navigator.Buttons.Remove)
            //    e.Handled = true;
  
        }

        private void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!_isLoaded) return;

            var entity = Tablo.GetRow<IBaseHareketEntity>();
            if (!entity.Insert)
                entity.Update = true;
            ButonenableDurumu(true);
        }
        protected virtual void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (popupMenu == null) return;

            btnHareketSil.Enabled = Tablo.RowCount > 0;
            btnHareketDuzenle.Enabled = Tablo.RowCount > 0;
            e.SagMenuGoster(popupMenu);
        }

        private void Tablo_GotFocus(object sender, EventArgs e)
        {
           OvnerForm.statusBarKisayol.Visibility = BarItemVisibility.Always;
           OvnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

           OvnerForm.statusBarAciklama.Caption = ((IStatusBarAciklama)sender).StatusBarAciklama;
           OvnerForm.statusBarKisayol.Caption = ((IStatusBarKisayol)sender).StatusBarKisayol;
           OvnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarKisayolAciklama;
        }

        private void Tablo_LostFocus(object sender, EventArgs e)
        {
            OvnerForm.statusBarKisayol.Visibility = BarItemVisibility.Never;
            OvnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (Tablo.IsEditorFocused)
                        ınsUptNavigator.Navigator.Buttons.DoClick(ınsUptNavigator.Navigator.Buttons.CancelEdit);
                    else
                        OvnerForm.Close();
                    break;
                case Keys.Tab:
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    ınsUptNavigator.Navigator.Buttons.DoClick(ınsUptNavigator.Navigator.Buttons.EndEdit);
                    break;
                case Keys.Insert when e.Shift:
                    HareketEkle();
                    break;
                case Keys.Delete when e.Shift:
                    HareketSil();
                    break;
                case Keys.F2:
                    OpenEntity();
                    break;

            }
        }

        protected virtual void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            if (OvnerForm == null) return;
            OvnerForm.statusBarKisayol.Visibility = BarItemVisibility.Never;
            OvnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;
            if (!e.FocusedColumn.OptionsColumn.AllowEdit)
                Tablo_GotFocus(sender, null);
            else if (((IStatusBarKisayol)e.FocusedColumn).StatusBarKisayol != null)
            {
                OvnerForm.statusBarKisayol.Visibility = BarItemVisibility.Always;
                OvnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

                OvnerForm.statusBarAciklama.Caption = ((IStatusBarAciklama)sender).StatusBarAciklama;
                OvnerForm.statusBarKisayol.Caption = ((IStatusBarKisayol)sender).StatusBarKisayol;
                OvnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarKisayolAciklama;
            }

            else if (((IStatusBarKisayol)e.FocusedColumn).StatusBarKisayolAciklama != null)
            {
                OvnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarKisayolAciklama;
            }
        }

        private void Tablo_SablonChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
            SablonKaydet();
        }

        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            OpenEntity();
        }

        protected virtual void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            SutunGizleGoster();
            RowCellAllowEdit();
        }

        private void RowCellAllowEdit()
        {

        }

        private void SutunGizleGoster()
        {

        }
    }
}
