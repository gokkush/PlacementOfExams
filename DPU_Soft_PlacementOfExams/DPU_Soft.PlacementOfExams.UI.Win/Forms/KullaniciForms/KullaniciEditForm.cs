using System;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using System.Security;
using DPU_Soft.PlacementOfExams.Common.Massage;
using System.Windows.Forms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.KullaniciForms
{
    public partial class KullaniciEditForm : BaseEditForm
    {
        private string _sifre;
        private string _gizliKelime;
        private SecureString _secureSifre;
        private SecureString _secureGizliKelime;
        private bool _tekrarGonder;

        public KullaniciEditForm()
        {
            InitializeComponent();

            DataLayoutControl = dpuDataLayoutControl;
            Bll = new KullaniciBll(dpuDataLayoutControl);
            BaseKartTuru = KartTuru.Kullanici;
            ShowItems = new BarItem[] { btnSifreSifirla};
            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KullaniciS() : ((KullaniciBll)Bll).Single(FilterFunctions.Filter<KullaniciEntity>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKullaniciAdi.Text = "Yeni Kullanıcı";
            btnSifreSifirla.Enabled = false;
            txtAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KullaniciS)OldEntity;
            txtKullaniciAdi.Text = entity.Kod;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.Soyadi;
            txtMail.Text = entity.Email;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new KullaniciEntity
            {
                Id = Id,
                Kod = txtKullaniciAdi.Text,
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                Email = txtMail.Text,
                Sifre = _sifre,
                GizliKelime=_gizliKelime,
                Aciklama = txtAciklama.Text,
                durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            SifreUret();
            var result = base.EntityInsert();
            if (result)
                txtKullaniciAdi.Text.SifreMailiGonder(txtMail.Text, _secureSifre,_secureGizliKelime);
            return result;
        }

        protected override bool EntityUpdate()
        {
            var result = base.EntityUpdate();
            if (_tekrarGonder)
                txtKullaniciAdi.Text.SifreMailiGonder(txtMail.Text, _secureSifre, _secureGizliKelime);
            return result;
        }

        private void SifreUret()
        {
            var result = GeneralFunctions.SifreUret();
            _sifre = result.sifre;
            _gizliKelime = result.gizliKelime;
            _secureSifre = result.secureSifre;
            _secureGizliKelime = result.secureGizliKelime;
            GuncelNesneOlustur();
        }

        protected override void SifreSifirla()
        {
            if (Messages.EmailgonderimOnayi() != DialogResult.Yes) return;
            _tekrarGonder = true;
            SifreUret();
            btnKaydet.PerformClick();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
                return;
            using (var sec = new SelectFunctions())
            {
               
            }

        }


    }
}