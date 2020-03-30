using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.OkulForms;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.Common.Enums;
>>>>>>> yandal
=======
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.IlForms;
>>>>>>> yandal

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string FakulteAdi = " Fakültesi";
        public static string DersAdi = " Dersi";

        public AnaForm()
        {
            InitializeComponent();
<<<<<<< HEAD
<<<<<<< HEAD
=======
            EventsLoad(this);
>>>>>>> yandal
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
        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnOkulKartlari)
                ShowListforms<OkulListForm>.ShowListForm(KartTuru.Okul);
            else if (e.Item==btnIlKartlari)
            {
                ShowListforms<IlListForm>.ShowListForm(KartTuru.Il);
            }

        }

        public void Mesaj(string Baslik, string Mesaj)
        {
            ALC.Show(this, Baslik, Mesaj);
        }
<<<<<<< HEAD
=======
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
        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnOkulKartlari)
                ShowListforms<OkulListForm>.ShowListForm(KartTuru.Okul);


        }

        public void Mesaj(string Baslik, string Mesaj)
        {
            ALC.Show(this, Baslik, Mesaj);
        }


>>>>>>> yandal
=======


>>>>>>> yandal
    }
}