using DevExpress.XtraEditors;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Configuration;
using DPU_Soft.PlacementOfExams.Common.Functions;
using DPU_Soft.PlacementOfExams.Common.Enums;

using DPU_Soft.BLL.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Show;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    public partial class GirisForm : XtraForm
    {
        private Point _mouseLocation;
        public GirisForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {
            foreach (Control control in Controls)
            {
                if (!(control is DpuDataLayoutControl)) continue;
                control.MouseDown += Control_MouseDown;
                control.MouseMove += Control_MouseMove;

                foreach (Control ctrl in Controls)
                {
                    ctrl.KeyDown += Control_KeyDown;
                    switch (ctrl)
                    {
                        case SimpleButton btn:
                            btn.Click += Control_Click;
                            break;
                        case DpuHyperLinkLabelControl hyp:
                            hyp.Click+= Control_Click;
                            break;
                    }
                }
            }
            Shown += GirisForm_Shown;
            Load += GirisForm_Load;
        }


        private void Yukle()
        {
            txtVersiyon.Text = $"Versiyon: {Assembly.GetExecutingAssembly().GetName().Version}";
            var server = ConfigurationManager.AppSettings["Server"];
            var yetkilendirmeTuru = ConfigurationManager.AppSettings["Yetki"].GetEnum<YetkilendirmeTuru>();
            var kullaniciAdi = ConfigurationManager.AppSettings["KullaniciAdi"].ConvertToSecureString();
            var sifre = ConfigurationManager.AppSettings["Sifre"].ConvertToSecureString();

            if (!Win.Functions.GeneralFunctions.BaglantiKontrolu(server,kullaniciAdi,sifre,yetkilendirmeTuru,true))
            {
                if (ShowEditforms<BaglantiAyarlariEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate))
                    Yukle();
                return;
            }

        }




        private void Giris()
        {

        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
                Close();
            
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            var position = MousePosition;
            position.Offset(_mouseLocation.X,_mouseLocation.Y);
            Location = position;
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = new Point(-e.X,-e.Y);
        }

        private void Control_Click(object sender, EventArgs e)
        {
            switch (sender)
            {
                case SimpleButton button:
                    if (button == btnGiris)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        Giris();
                        Cursor.Current = Cursors.Default;
                    }
                    else if (button == btnCikis)
                        Close();
                    break;
                case DpuHyperLinkLabelControl hyp:

                    break;

            }
            
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

            Yukle();
        }

        private void GirisForm_Shown(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }

    }
}