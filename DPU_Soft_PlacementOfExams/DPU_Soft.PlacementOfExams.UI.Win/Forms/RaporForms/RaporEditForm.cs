using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.RaporForms
{
    public partial class RaporEditForm : BaseEditForm
    {
        private readonly KartTuru _raporTuru;
        private readonly RaporBolumTuru _raporBolumTuru;
        private readonly byte[] _dosya;
        public RaporEditForm(params object[]prm)
        {
            InitializeComponent();
            DataLayoutControl = dpuDataLayoutControl;
            Bll = new RaporBll(dpuDataLayoutControl);
            BaseKartTuru = KartTuru.RaporTuru;
            EventsLoad();

            _raporTuru = (KartTuru)prm[0];
            _raporBolumTuru = (RaporBolumTuru)prm[1];
            _dosya = (byte[])prm[2];
        }



        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new RaporEntity() : ((RaporBll)Bll).Single(FilterFunctions.Filter<RaporEntity>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((RaporBll)Bll).YeniKodVer(x=>x.RaporBolumTuru==_raporBolumTuru);
            txtRaporAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (RaporEntity)OldEntity;

            txtKod.Text = entity.Kod;
            txtRaporAdi.Text = entity.RaporAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new RaporEntity
            {
                Id = Id,
                Kod = txtKod.Text,
                RaporAdi = txtRaporAdi.Text,
                RaporTuru=_raporTuru,
                RaporBolumTuru=_raporBolumTuru,
                Dosya=_dosya,
                Aciklama = txtAciklama.Text,
                durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((RaporBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.RaporBolumTuru == _raporBolumTuru);
        }
        protected override bool EntityUpdate()
        {
            return ((RaporBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.RaporBolumTuru == _raporBolumTuru);
        }
    }
}