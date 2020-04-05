using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.OkulForms;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.KullaniciForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.SinavSalonForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GozetmenForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.DersForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.SinavKayitForms;
using DPU_Soft.BLL.General;
using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.PlacementOfExams.Model.Dto;
using System.Linq;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string KurumAdi = "Üniversite";
        public static long DonemId;
        public static string DonemAdi = "Dönemi...";
        public static long SubeId;
        public static string SubeAdi = "Dönemi...";
        public static long KullaniciId;
        public static string KullaniciAdi;
        public static List<long> YetkiliOlunanSubeler = new List<long>() ;
        public static DonemEntity Donem;

        public AnaForm()
        {
            InitializeComponent();
            EventsLoad(this);
        }

        private void EventsLoad(object sender)
        {

            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                }


            }
            FormClosing += AnaForm_FormClosing;
        }
        private void SubeDonemSecimi(bool subeSecimButonunaBasildi)
        {
            ShowEditforms<SubeDonemSecimiEditForm>.ShowDialogEditForm(null,KullaniciId,subeSecimButonunaBasildi,SubeId,DonemId);
            barDonem.Caption = DonemAdi;
            btnSubeSecim.Caption = SubeAdi;
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnOkulKartlari)
                ShowListforms<OkulListForm>.ShowListForm(KartTuru.Okul);
            else if (e.Item==btnGozetmen)
            {
                //ShowListforms<GozetmenListForm>.ShowListForm(KartTuru.Gozetmen,SubeId, SubeAdi);
                ShowListforms<GozetmenListForm>.ShowListForm(KartTuru.Gozetmen); //Eğer Gözetmenler tüm fakültelerde aynı ise
            }
            else if (e.Item==btnSinavSalon)
            {
                ShowListforms<SinavSalonuListForm>.ShowListForm(KartTuru.Salon);
            }
            else if (e.Item==btnSubeSecim)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i] is GirisForm || Application.OpenForms[i] is AnaForm) continue;
                    Application.OpenForms[i].Close();
                    i--;
                }

                SubeDonemSecimi(true);
            }
            else if (e.Item==btnSifreDegistir)
            {
                ShowEditforms<SifreDegistirEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate);
            }
            else if (e.Item == btnDers)
            {
                ShowListforms<DersListForm>.ShowListForm(KartTuru.Ders);
            }
            else if (e.Item == btnSinavKayitlari)
            {
                ShowListforms<SinavKayitListForm>.ShowListForm(KartTuru.SinavKayit);
            }

            Cursor.Current = Cursors.Default;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            barKullanici.Caption = KullaniciAdi;
            barKurum.Caption = KurumAdi;
            SubeDonemSecimi(false);

            if (Donem==null) 
            {
                Messages.HataMesaji("Dönem Parametreleri yüklenemedi. Sistem Yöneticisine Başvurunuz.");
                Application.ExitThread();
                return;
            }
        }
    }
}