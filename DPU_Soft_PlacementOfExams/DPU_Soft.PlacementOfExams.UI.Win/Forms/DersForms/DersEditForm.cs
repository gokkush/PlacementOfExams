using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.DersForms
{
    public partial class DersEditForm : BaseEditForm
    {
        public DersEditForm()
        {
            InitializeComponent();
            DataLayoutControl = dpuDataLayoutControl;
            Bll = new DersBll(dpuDataLayoutControl);
            BaseKartTuru = KartTuru.Ders;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new DersEntity() : ((DersBll)Bll).Single(FilterFunctions.Filter<DersEntity>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((DersBll)Bll).YeniKodVer();
            txtDersAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (DersEntity)OldEntity;

            txtKod.Text = entity.Kod;
            txtDersAdi.Text = entity.DersAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new DersEntity
            {
                Id = Id,
                Kod = txtKod.Text,
                DersAdi = txtDersAdi.Text,
                Aciklama = txtAciklama.Text,
                DonemId=AnaForm.DonemId,
                SubeId=AnaForm.SubeId,
                durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();
        }


    }
}