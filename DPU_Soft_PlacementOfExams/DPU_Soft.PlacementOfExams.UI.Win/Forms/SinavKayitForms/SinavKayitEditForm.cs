using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.Common.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms;
using DevExpress.XtraEditors;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.SinavKayitForms
{
    public partial class SinavKayitEditForm : BaseEditForm
    {
        private string _sinavAdi;
        public SinavKayitEditForm()
        {
            InitializeComponent();
            DataLayoutControls = new[] {dpuDataLayoutControlDis, dpuDataLayoutControlGenelBilgiler };
            Bll = new SinavKayitBll(dpuDataLayoutControlGenelBilgiler);
            BaseKartTuru = KartTuru.SinavKayit;
            EventsLoad();

            HideItems = new BarItem[] {btnYeni };
            ShowItems = new BarItem[] { btnExceldenAl };
            txtSinavTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<SinavTuru>());
            btnYazdir.Caption = "Sınav Kayıtları";

        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SinavKayitS() : ((SinavKayitBll)Bll).Single(FilterFunctions.Filter<SinavKayitEntity>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SinavKayitBll)Bll).YeniKodVer(x=>x.SubeId==AnaForm.SubeId&&x.DonemId==AnaForm.DonemId);
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SinavKayitS)OldEntity;
            _sinavAdi = entity.SinavAdi;
            txtKod.Text = entity.Kod;
            txtDers.Id = entity.DersId;
            txtDers.Text = entity.DersAdi;
            txtSinavTuru.SelectedItem = entity.SinavTuru.ToName();
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new SinavKayitEntity
            {
                Id = Id,
                Kod = txtKod.Text,
                DersId = (long)txtDers.Id,
                DonemId = AnaForm.DonemId,
                SubeId = AnaForm.SubeId,
                SinavAdi = BaseIslemTuru == IslemTuru.EntityInsert ? txtDers.Text + " (" + AnaForm.SubeAdi + ") (" + AnaForm.DonemAdi:_sinavAdi+")",
                Aciklama = txtAciklama.Text,
                durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((SinavKayitBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == x.DonemId);
        }
        protected override bool EntityUpdate()
        {
            return ((SinavKayitBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == x.DonemId);
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