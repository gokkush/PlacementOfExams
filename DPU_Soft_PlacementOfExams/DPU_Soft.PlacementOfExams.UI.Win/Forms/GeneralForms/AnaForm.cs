﻿using System;
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
=======
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.Common.Enums;
>>>>>>> yandal

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
<<<<<<< HEAD
        }

        private void EventsLoad()
        {
            //foreach (var item in ribbonControl.)
            //{
                
            //    switch (item)
            //    {
            //        case BarButtonItem btn:
            //            btn.ItemClick += ButonlarItemClick;
            //            break;
            //    }
            //}
        }
        public void Mesaj(string Baslik, string Mesaj)
        {
            ALC.Show(this, Baslik, Mesaj);
        }

        private void btnOkulKartlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            OkulKartlari frm = new OkulKartlari();
            frm.MdiParent = ActiveForm;
            frm.Show();
        }
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
    }
}