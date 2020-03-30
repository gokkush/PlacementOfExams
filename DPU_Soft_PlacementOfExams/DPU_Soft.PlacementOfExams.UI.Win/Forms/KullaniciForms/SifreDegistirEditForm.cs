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
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.BLL.General;
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms;
using DPU_Soft.BLL.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.KullaniciForms
{
    public partial class SifreDegistirEditForm : BaseEditForm
    {
        public SifreDegistirEditForm()
        {
            InitializeComponent();
            DataLayoutControl = dpuDataLayoutControl;
            Bll = new KullaniciBll(dpuDataLayoutControl);
            HideItems = new BarItem[] { btnYeni, btnGeriAl, btnSil, };
            EventsLoad();
        }

        private void SifreDegistir()
        {
            if (Messages.KayitMesaj() != DialogResult.Yes) return;
            var entity = ((KullaniciBll)Bll).SingleDetail(x => x.Id == AnaForm.KullaniciId).EntityConvert<KullaniciEntity>();
            if (entity == null) return;
            if (HataliGiris()) return;
            if (entity.Sifre == txtEskiSifre.Text.md5Sifrele())
            {
                var currentEntity = new KullaniciEntity
                {
                    Id = entity.Id,
                    Kod = entity.Kod,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    Email=entity.Email,
                    Sifre = txtYeniSifre.Text.md5Sifrele(),
                    GizliKelime = string.IsNullOrEmpty(txtGizliKelime.Text) ? entity.GizliKelime : txtGizliKelime.Text.md5Sifrele(),
                    Aciklama = entity.Aciklama,
                    durum = entity.durum


                };
                if (!((KullaniciBll)Bll).Update(entity, currentEntity)) return;
                else
                    Messages.UyariMesaji("Şifreniz Değiştirilmiştir.");
                btnKaydet.Enabled = false;
                    
                Close();
            }
            else 
            {
                Messages.HataMesaji("Girilen Eski Şifre Bilgisi Hatalıdır. Lütfen Tekrar Deneyiniz.");
                txtEskiSifre.Focus();
            }
        }

        private bool HataliGiris()
        {
            if (txtYeniSifre.Text!=txtYeniSifreTekrar.Text)
            {
                Messages.HataMesaji("Yeni Şifre, Tekrar Alanı İle Uyuşmamaktadır. Lütfen Yeni Şifreleri yeninden Giriniz.");
                return true;
            }

            if (txtYeniSifre.Text.Length<6)
            {
                Messages.HataMesaji("Yeni Şifreniz En Az 6 Karakter Olmalıdır.");
                txtYeniSifre.Focus();
                return true;
            }
            if (!string.IsNullOrEmpty(txtGizliKelime.Text) && txtGizliKelime.Text.Length<4)
            {
                Messages.HataMesaji("Girilen Gizli Kelimenin Uzunluğu En Az 4 Karakter Olmalıdır.");
                txtYeniSifre.Focus();
                return true;
            }
            return false;
        }

        protected override void Buttom_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnKaydet)
                SifreDegistir();
            else if (e.Item == btnCikis)
                Close();
            
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }

    }
}