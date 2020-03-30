using System;
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
using DPU_Soft.PlacementOfExams.UI.Win.Show.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DevExpress.XtraGrid.Views.Grid;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using DPU_Soft.BLL.Base.Interfaces;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        protected IBaseFormshow FormShow;
        protected KartTuru BaseKartTuru;
        protected internal GridView Tablo;
        protected bool AktifKartlariGoster=true;
        protected internal bool MultiSelect;
        protected internal BaseEntity SecilenEntity;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;
        protected internal long? SeciliGelecekId;

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
            //Form Events
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
        }

        private void EntityDelete()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private void Yazdir()
        {
            throw new NotImplementedException();
        }

        private void FormCaptionAyarla()
        {
            throw new NotImplementedException();
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

            if (e.Item==btnGonder) 
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
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
            else if (e.Item == btnYeni)
            {
                //Yetki Kontrolü
                ShowEditForm(-1);
            }
            else if (e.Item == btnDuzelt)
            {
                ShowEditForm(Tablo.GetRowId());
            }
            else if (e.Item== btnSil)
            {
                //Yetki Kontrolü
                EntityDelete();
            }

            else if (e.Item==btnSeç)
            {
                SelectEntity();
            }

            else if (e.Item==btnYenile)
            {
                Listele();
            }

            else if (e.Item==btnFiltrele)
            {
                FiltreSec();
            }

            else if (e.Item==btnKolonlar)
            {
                if (Tablo.CustomizationForm == null)
                {
                    Tablo.ShowCustomization();
                }
                else Tablo.HideCustomization();
            }

            else if (e.Item==btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item==btnCikis)
            {
                Close();
            }

            else if (e.Item==btnAktifPasifKartlar)
            {
                AktifKartlariGoster = !AktifKartlariGoster;
                FormCaptionAyarla();
            }

            Cursor.Current = DefaultCursor;
        }

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