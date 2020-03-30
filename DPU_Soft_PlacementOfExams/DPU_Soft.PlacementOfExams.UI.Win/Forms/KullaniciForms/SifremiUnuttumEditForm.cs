using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DevExpress.XtraBars;
using DPU_Soft.BLL.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using System.Windows.Forms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.KullaniciForms
{
    public partial class SifremiUnuttumEditForm : BaseEditForm
    {
        private readonly string _kullaniciAdi;
        public SifremiUnuttumEditForm(params object[] prm)
        {
            InitializeComponent();
            DataLayoutControl = dpuDataLayoutControl;
            Bll = new KullaniciBll(dpuDataLayoutControl);
            HideItems = new BarItem[] { btnYeni,btnKaydet,btnGeriAl,btnSil,};
            ShowItems = new BarItem[] { btnSifreSifirla };
            EventsLoad();
            _kullaniciAdi = prm[0].ToString();
            
            
        }

        public override void Yukle()
        {
            txtKullaniciAdi.Text = _kullaniciAdi;
            txtMail.Focus();
        }
        protected override void SifreSifirla()
        {
            if (Messages.EmailgonderimOnayi() != DialogResult.Yes) return;

            var entity = ((KullaniciBll)Bll).SingleDetail(x => x.Kod == txtKullaniciAdi.Text).EntityConvert<KullaniciEntity>();

            if (entity == null)
            {
                Messages.HataMesaji("Böyle bir kullanıcı bulunamadı.");
                return;
            }
            if (txtMail.Text == entity.Email && txtGizliKelime.Text.md5Sifrele() == entity.GizliKelime)
            {
                var result = Win.Functions.GeneralFunctions.SifreUret();

                var currentEntity = new KullaniciEntity
                {
                    Id = entity.Id,
                    Kod = entity.Kod,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    Email = entity.Email,
                    Aciklama = entity.Aciklama,
                    durum = entity.durum,
                    Sifre = result.sifre,
                    GizliKelime = result.gizliKelime
                };

                if (!((KullaniciBll)Bll).Update(entity, currentEntity)) return;
                var sonuc = txtKullaniciAdi.Text.SifreMailiGonder(entity.Email, result.secureSifre, result.secureGizliKelime);

                if (sonuc)
                {
                    Messages.UyariMesaji("Şifre Sıfırlanarak Mail Adresinize Gönderildi");
                    Close();
                }
                else
                    Messages.HataMesaji("Şifre Sıfırlama İşlemi Başarılı ancak E-Mail Gönderilemedi. Tekrar Deneyiniz.");
            }
            else
                Messages.HataMesaji("Girilen Bilgiler Mevcut Bilgilerle Uyuşmamaktadır. Lütfen Yeniden Deneyiniz.");

        }

    }
}