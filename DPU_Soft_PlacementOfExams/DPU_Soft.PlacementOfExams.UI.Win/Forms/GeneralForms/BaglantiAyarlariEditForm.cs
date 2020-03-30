using System;
using System.Linq;
using DevExpress.XtraEditors;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.Common.Functions;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.Model.Entities;
using System.Configuration;
using DPU_Soft.BLL.Functions;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    public partial class BaglantiAyarlariEditForm : BaseEditForm
    {
        public BaglantiAyarlariEditForm()
        {
            InitializeComponent();

            DataLayoutControl = dpuDataLayoutControl;
            HideItems = new BarItem[] { btnYeni, btnSil };
            txtYetkilendirmeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());
            EventsLoad();

        }

        protected internal override void Yukle()
        {
            OldEntity = new BaglantiAyarlari
            {
                Server= ConfigurationManager.AppSettings["Server"],
                YetkilendirmeTuru= ConfigurationManager.AppSettings["Yetki"].GetEnum<YetkilendirmeTuru>(),
                KullaniciAdi= ConfigurationManager.AppSettings["KullaniciAdi"].ConvertToSecureString(),
                Sifre= ConfigurationManager.AppSettings["Yetki"].GetEnum<YetkilendirmeTuru>()==YetkilendirmeTuru.SqlServer?"Burası Şifre Alanıdır".ConvertToSecureString():"".ConvertToSecureString()
            };
            NesneyiKontrollereBagla();
        }

        protected override void NesneyiKontrollereBagla()
        {
            txtServer.Text = ConfigurationManager.AppSettings["Server"];
            txtYetkilendirmeTuru.SelectedItem = ConfigurationManager.AppSettings["Yetki"];
            txtKullaniciAdi.Text = ConfigurationManager.AppSettings["KullaniciAdi"];
            txtSifre.Text = ConfigurationManager.AppSettings["Yetki"].GetEnum<YetkilendirmeTuru>() == YetkilendirmeTuru.SqlServer ? "Şifre Gizlidir": "";

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new BaglantiAyarlari
            {
                Server = txtServer.Text,
                YetkilendirmeTuru = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>(),
                KullaniciAdi = txtKullaniciAdi.Text.ConvertToSecureString(),
                Sifre = txtSifre.Text.ConvertToSecureString() 
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityUpdate()
        {
            var list = BLL.Functions.GeneralFunctions.DegisenAlanalariGetir(OldEntity,CurrentEntity).ToList();
            list.ForEach(x =>
            {
                switch (x)
                {
                    case "Server":
                        Win.Functions.GeneralFunctions.AppSettingsWrite(x, txtServer.Text);
                        break;
                    case "Yetki":
                        Win.Functions.GeneralFunctions.AppSettingsWrite(x, txtYetkilendirmeTuru.Text);
                        break;

                    case "KullaniciAdi":
                        Win.Functions.GeneralFunctions.AppSettingsWrite(x, txtKullaniciAdi.Text);
                        break;

                    case "Sifre":
                        Win.Functions.GeneralFunctions.AppSettingsWrite(x, txtSifre.Text);
                        break;
                    default:
                        break;
                }
            }
            );
            return true;
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edit)) return;
            var yetkilendirmeTuru = edit.Text.GetEnum<YetkilendirmeTuru>();
            txtKullaniciAdi.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtSifre.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtKullaniciAdi.Focus();

            if (yetkilendirmeTuru != YetkilendirmeTuru.Windows) return;
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";

        }
    }
}