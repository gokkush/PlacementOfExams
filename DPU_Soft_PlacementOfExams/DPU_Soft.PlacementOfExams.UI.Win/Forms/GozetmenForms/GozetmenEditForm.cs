using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GozetmenForms
{
    public partial class GozetmenEditForm : BaseEditForm
    {
        public GozetmenEditForm()
        {
            InitializeComponent();
            DataLayoutControl = dpuDataLayoutControl;
            Bll = new GozetmenBll(dpuDataLayoutControl);
            BaseKartTuru = KartTuru.Gozetmen;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new GozetmenEntity() : ((GozetmenBll)Bll).Single(FilterFunctions.Filter<GozetmenEntity>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((GozetmenBll)Bll).YeniKodVer();
            txtGozetmenAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (GozetmenEntity)OldEntity;

            txtKod.Text = entity.Kod;
            txtGozetmenAdi.Text = entity.GozetmenAdi;
            txtGozetmenSoyadi.Text = entity.GozetmenSoyadi;
            txtGorevlendirmeSayisi.Value = entity.GorevlendirmeSayisi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new GozetmenEntity
            {
                Id = Id,
                Kod = txtKod.Text,
                GozetmenAdi = txtGozetmenAdi.Text,
                GozetmenSoyadi = txtGozetmenSoyadi.Text,
                GozetmenSubeId = AnaForm.SubeId,
                GorevlendirmeSayisi = (int)txtGorevlendirmeSayisi.Value,
                Aciklama = txtAciklama.Text,
                durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();
        }

    }
}