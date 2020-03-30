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
using DPU_Soft.BLL.General;
using System.Collections.Generic;
using DPU_Soft.PlacementOfExams.Model.Entities;
using System.Linq;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.KullaniciForms;
using DevExpress.XtraSplashScreen;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    public partial class GirisForm : XtraForm
    {
        private Point _mouseLocation;
        private List<KurumEntity> _source;
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

                foreach (Control ctrl in control.Controls)
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
            var yetkilendirmeTuru = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>();
            var kullaniciAdi = ConfigurationManager.AppSettings["KullaniciAdi"].ConvertToSecureString();
            var sifre = ConfigurationManager.AppSettings["Sifre"].ConvertToSecureString();

            if (!Win.Functions.GeneralFunctions.BaglantiKontrolu(server,kullaniciAdi,sifre,yetkilendirmeTuru,true))
            {
                txtFakulte.Properties.DataSource = null;
                if (ShowEditforms<BaglantiAyarlariEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate))
                    Yukle();
                return;
            }

            Win.Functions.GeneralFunctions.CreateConnectionString("DPU_Soft_PlacementOfExams_Yonetim", server, kullaniciAdi, sifre, yetkilendirmeTuru);

            using (var bll= new KurumBll())
            {
               _source=bll.List(null).Cast<KurumEntity>().ToList();

                txtFakulte.Properties.DataSource = _source;
                txtFakulte.Properties.ValueMember = "Kod";
                txtFakulte.Properties.DisplayMember = "KurumAdi";
                txtFakulte.ItemIndex = 0;
            }
        }


        private void CreateConnetction()
        {
            if (txtFakulte.Text=="")
            {
                Messages.HataMesaji("Kurum Seçimi Yapmalısınız.");
                txtFakulte.Focus();
                return;
            }

            var kurum = _source[txtFakulte.ItemIndex];
            var kod = kurum.Kod;
            var server = kurum.Server;
            var kullaniciAdi = kurum.KullaniciAdi.Decrypt(kurum.Id+kurum.Kod).ConvertToSecureString();
            var sifre = kurum.Sifre.Decrypt(kurum.Id + kurum.Kod).ConvertToSecureString();
            var yetkilendirmeTuru = kurum.YetkilendirmeTuru;
            if (!Win.Functions.GeneralFunctions.BaglantiKontrolu(server, kullaniciAdi, sifre, yetkilendirmeTuru)) return;

            Win.Functions.GeneralFunctions.CreateConnectionString(kod, server, kullaniciAdi, sifre, yetkilendirmeTuru);
        }

        private void Giris()
        {
            CreateConnetction();

            using (var kullaniciBll=new KullaniciBll())
            {
                var kullanici = (KullaniciS)kullaniciBll.SingleDetail(x => x.Kod == txtKullaniciAdi.Text);
                if (kullanici==null||txtSifre.Text.md5Sifrele()!=kullanici.Sifre)
                {
                    Messages.HataMesaji("Kullanıcı Adı veya Şifre Hatalıdır. Lüten Kontrol Edip tekrar Deneyiniz.");
                    txtKullaniciAdi.Focus();
                    return;
                }
                if (!kullanici.durum)
                {
                    Messages.HataMesaji("Pasif Kullanıcı ile Giriş Yapamazsınız.");
                    txtKullaniciAdi.Focus();
                    return;
                }
                AnaForm.KurumAdi = txtFakulte.Text;
                AnaForm.KullaniciId = kullanici.Id;
                AnaForm.KullaniciAdi = kullanici.Adi+" "+kullanici.Soyadi;

                Hide();
                ShowRibbonForms<AnaForm>.ShowForm(false);


            }
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
                    if (hyp == btnBaglantiAyarlari)
                    {
                        if (ShowEditforms<BaglantiAyarlariEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate))
                            Yukle();
                    }
                    else if (hyp==btnSifremiUnuttum)
                    {
                        CreateConnetction();
                        ShowEditforms<SifremiUnuttumEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate, txtKullaniciAdi.Text);
                    }
                    break;

            }  
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {
            //Splash
            Yukle();
            //Splash
        }

        private void GirisForm_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(BaslatmaEkrani));
            txtKullaniciAdi.Focus();
            SplashScreenManager.CloseForm();
        }

    }
}