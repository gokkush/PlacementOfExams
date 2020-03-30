using System;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UniversiteForms
{
    public partial class UnvEditForm : BaseEditForm
    {
        public UnvEditForm()
        {
            InitializeComponent();
            DataLayoutControl = dpuDataLayoutControl;
            Bll = new UniversiteBll(dpuDataLayoutControl);
            BaseKartTuru = KartTuru.Universite;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new UniversiteEntity() : ((UniversiteBll)Bll).Single(FilterFunctions.Filter<UniversiteEntity>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            txtKod.Text = ((UniversiteBll)Bll).YeniKodVer();
            txtUnvAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (UniversiteEntity)OldEntity;

            txtKod.Text = entity.Kod;
            txtUnvAdi.Text = entity.UniversiteAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new UniversiteEntity
            {
                Id = Id,
                Kod = txtKod.Text,
                UniversiteAdi = txtUnvAdi.Text,
                Aciklama = txtAciklama.Text,
                durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();
        }

    }
}