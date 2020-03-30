
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Dpu_Soft.PlacementOfExams.UI.Yonetim.Forms.Genelforms;
using DPU_Soft.BLL.Functions;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Common.Functions;
using DPU_Soft.PlacementOfExams.Data.Contexts;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace DPU_Soft.PlacementOfExams.UI.Yonetim.Forms.Genelforms
{
    public partial class GirisForm : XtraForm
    {

        private Point _mouseLocation;
        public GirisForm()
        {
            InitializeComponent();
            txtYetkilendirmeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());
            EventsLoad();
        }

        private void EventsLoad()
        {

            //Control Eventleri
            foreach (Control control in Controls)
            {
                if (!(control is DpuDataLayoutControl)) continue;
                control.MouseDown += Control_MouseDown;
                control.MouseMove += Control_MouseMove;

                foreach (Control ctrl in control.Controls)
                {
                    ctrl.KeyDown += Control_KeyDown;
                    switch (ctrl)
                    {
                        case SimpleButton btn:
                            btn.Click += Control_Click;
                            break;
                        case DpuComboBoxEdit edt:
                            edt.SelectedValueChanged += Control_SelectedValueChanged;
                            break;

                        
                    }
                }
            }

            //Form Eventleri
            Shown += GirisForm_Shown;
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = new Point(-e.X,-e.Y);
        }
        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            var position = MousePosition;
            position.Offset(_mouseLocation.X,_mouseLocation.Y);
            Location = position;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void Control_Click(object sender, System.EventArgs e)
        {
            if (!(sender is SimpleButton button)) return;
            if (button == btnGiris)
                Giris();
            else if (button == btnCikis)
                Close();
        }
        private void Control_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (!(sender is ComboBoxEdit edt)) return;
            var yetkilendirmeTuru = edt.Text.GetEnum<YetkilendirmeTuru>();
            txtKullaniciAdi.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtSifre.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtKullaniciAdi.Focus();
            if (yetkilendirmeTuru != YetkilendirmeTuru.Windows) return;
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        private void GirisForm_Shown(object sender, System.EventArgs e)
        {
            Yukle();
        }

        private void Yukle()
        {
            txtVersiyon.Text = $"Versiyon: {Assembly.GetExecutingAssembly().GetName().Version}";

            var connectionStringArray = BLL.Functions.GeneralFunctions.GetConnectionString().Split(';');
            var dictionary = new Dictionary<string, string>();
            connectionStringArray.ForEach(x =>
            {
                var row = x.Split('=');
                dictionary.Add(row[0],row[1]);
            });

            txtServer.Text = dictionary.GetValueOrDefault("Data Source", "");
            txtYetkilendirmeTuru.SelectedItem = dictionary.ContainsKey("Password") ? YetkilendirmeTuru.SqlServer.ToName():YetkilendirmeTuru.Windows.ToName();

            if (txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>() == YetkilendirmeTuru.SqlServer)
                txtKullaniciAdi.Focus();
            else
                btnGiris.Focus();
        }

        private void Giris()
        {
            if (!Win.Functions.GeneralFunctions.BaglantiKontrolu(txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>())) return;
            Win.Functions.GeneralFunctions.CreateConnectionString("DPU_Soft_PlacementOfExams_Yonetim", txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());

            if (!Functions.GeneralFunctions.CreateDatabase<PlacementOfExamsYonetimContext>("Lütfen Bekleyiniz", "Program İlk Kurulum İçin Hazırlanıyor...", "İlk Kurulum İşlemi Yapılacaktır. Onaylıyor musunuz?", "İlk Kurulum İşlemi Başarılı Bir Şekilde Yapıldı.")) return;
            Hide();
            ShowRibbonForms<AnaForm>.ShowForm(false, txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }










    }
}