using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSplashScreen;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.Data.Contexts;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.DonemForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.KullaniciForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.Subeforms;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.UI.Yonetim.Forms.Genelforms;
using System;
using System.Security;
using System.Windows.Forms;


namespace Dpu_Soft.PlacementOfExams.UI.Yonetim.Forms.Genelforms
{
    public partial class AnaForm : RibbonForm
    {
        private readonly string _server;
        private readonly SecureString _kullaniciAdi;
        private readonly SecureString _sifre;
        private readonly YetkilendirmeTuru _yetkilendirmeTuru;
        private readonly KurumBll _bll;
             

        public AnaForm(params object[] prm)
        {

            InitializeComponent();

            longNavigator.Navigator.NavigatableControl = tablo.GridControl;
            EventsLoad();
            ButtonEnabledDurumu();

            _server = prm[0].ToString();
            _kullaniciAdi = (SecureString)prm[1];
            _sifre = (SecureString)prm[2];
            _yetkilendirmeTuru = (YetkilendirmeTuru)prm[3];
            _bll = new KurumBll();
        }

        private void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
            {
                button.ItemClick += Button_ItemClick;
            }

            //Tablo Events

            tablo.DoubleClick += Tablo_DoubleClick;
            tablo.KeyDown += Tablo_KeyDown;
            tablo.MouseUp += Tablo_MouseUp;
            tablo.RowCountChanged += Tablo_RowCountChanged;

            //Forms Event
            FormClosing += AnaForm_FormClosing;
            Load += AnaForm_Load;
        }



        protected virtual void ShowEditForm(long id)
        {
            
            GeneralFunctions.CreateConnectionString("DPU_Soft_PlacementOfExams_Yonetim",_server,_kullaniciAdi,_sifre,_yetkilendirmeTuru);

            var result = ShowEditforms<KurumEditForm>.ShowDialogEditForm(id, _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);
            if (result <= 0) return;
            Listele();
            tablo.RowFocus("Id", result);
        }

        private void ButtonEnabledDurumu()
        {
            foreach (BarItem button in ribbonControl.Items)
            {
                if (!(button is BarButtonItem item)) continue;
                if (item != btnYeni)
                    item.Enabled = tablo.DataRowCount > 0;
            }


        }

        private void EntityDelete(BaseEntity entity)
        {
            GeneralFunctions.CreateConnectionString(entity.Kod, _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);
            if (!DPU_Soft.PlacementOfExams.UI.Yonetim.Functions.GeneralFunctions.DeleteDatabase<PlacementOfExamsYonetimContext>()) return;
            GeneralFunctions.CreateConnectionString("DPU_Soft_PlacementOfExams_Yonetim", _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);
            _bll.Delete(entity);
            tablo.DeleteSelectedRows();
            tablo.RowFocus(tablo.FocusedRowHandle);

        }

        protected internal void Listele()
        {
            tablo.GridControl.DataSource = _bll.List(null);
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item==btnYeni||e.Item==btnDuzelt)
            {
                if (e.Item==btnYeni)
                {
                    ShowEditForm(-1);
                }
                else if (e.Item==btnDuzelt)
                {
                    ShowEditForm(tablo.GetRowId());
                }


            }
            else
            {
                var entity = tablo.GetRow<KurumEntity>();
                if (entity == null) return;
                GeneralFunctions.CreateConnectionString(entity.Kod, _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);


                if (e.Item==btnSil)
                {
                    EntityDelete(entity);
                }
                else if (e.Item == btnEmailParametreleri)
                {
                    ShowEditforms<EmailParametreEditForm>.ShowDialogEditForm();
                }
                else if (e.Item==btnSubekartlari)
                {
                    ShowListforms<SubeListForm>.ShowDialogListForm();
                }
                else if (e.Item==btnDonemKartlari)
                {
                    ShowListforms<DonemListForm>.ShowDialogListForm();
                }
                else if (e.Item==btnKullaniciKartlari)
                {
                    ShowListforms<KullaniciListForm>.ShowDialogListForm();
                }
                else if (e.Item==btnKullaniciYetkileri)
                {
                    ShowEditforms<KullanicibirimYetkileriEditForm>.ShowDialogEditForm();
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            if (tablo.FocusedRowHandle < 0) return;
            ShowEditForm(tablo.GetRowId());
        }
        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            if (tablo.FocusedRowHandle < 0) return;

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ShowEditForm(tablo.GetRowId());
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            e.SagMenuGoster(sagMenu);
        }

        private void Tablo_RowCountChanged(object sender, EventArgs e)
        {
            ButtonEnabledDurumu();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Messages.HayirSeciliEvetHayir("Programdan Çıkmak İstiyor musunuz?", "Çıkış Onayı") == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;

        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            var splashForm = new SplashScreenManager(this, typeof(BekleForm), true, true);
            splashForm.ShowWaitForm();
            splashForm.SetWaitFormCaption("Lütfen Bekleyiniz!");
            splashForm.SetWaitFormDescription("VeriTabanından \nÜniversite Bilgileriniz Yükleniyor...");
            Listele();
            tablo.Focus();
            splashForm.CloseWaitForm();
        }
    }
}