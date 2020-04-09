using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DevExpress.XtraEditors;
using System;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.OgrenciForms
{
    public partial class OgrenciListeAlEditForm : BaseEditForm
    {
        private string _kod;
        public OgrenciListeAlEditForm()
        {
            InitializeComponent();
            DataLayoutControl = dpuDataLayoutControl;
            Bll = new OgrenciBll(dpuDataLayoutControl);
            BaseKartTuru = KartTuru.Ogrenci;
            HideItems = new DevExpress.XtraBars.BarItem[] { btnYeni,btnSil,btnGeriAl };
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OgrenciS() : ((OgrenciBll)Bll).Single(FilterFunctions.Filter<OgrenciEntity>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            _kod = ((OgrenciBll)Bll).YeniKodVer();
            txtDers.Focus();
        }


        protected override void GuncelNesneOlustur()
        {
            for (int i = 0; i < tablo.RowCount; i++)
            {
                CurrentEntity = new OgrenciEntity
                {
                    Id = Id,
                    Kod = _kod,
                    OgrenciAdi = tablo.GetRowCellValue(i, "OgrAdiSoyadi").ToString(),
                    durum=true


                };
            ButtonEnabledDurumu();
             }


    }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
                return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtDers)
                    sec.Sec(txtDers);
            }

        }


    }
}