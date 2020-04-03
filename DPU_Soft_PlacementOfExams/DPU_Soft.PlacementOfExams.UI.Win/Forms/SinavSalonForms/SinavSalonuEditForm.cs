using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.SinavSalonForms
{
    public partial class SinavSalonuEditForm : BaseEditForm
    {
        public SinavSalonuEditForm()
        {
            InitializeComponent();
            DataLayoutControl = dpuDataLayoutControl;
            Bll = new SinavSalonuBll(dpuDataLayoutControl);
            BaseKartTuru = KartTuru.Salon;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SinavSalonuEntity() : ((SinavSalonuBll)Bll).Single(FilterFunctions.Filter<SinavSalonuEntity>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SinavSalonuBll)Bll).YeniKodVer();
            txtSalonAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SinavSalonuEntity)OldEntity;

            txtKod.Text = entity.Kod;
            txtSalonAdi.Text = entity.SalonAdi;
            txtSalonKapasitesi.Value = entity.SalonKapasitesi;
            txtGozetmenSayisi.Value = entity.GozetmenSayisi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new SinavSalonuEntity
            {
                Id = Id,
                Kod = txtKod.Text,
                SalonAdi = txtSalonAdi.Text,
                SalonKapasitesi=(int)txtSalonKapasitesi.Value,
                GozetmenSayisi=(int)txtGozetmenSayisi.Value,
                Aciklama = txtAciklama.Text,
                durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();
        }

    }
}