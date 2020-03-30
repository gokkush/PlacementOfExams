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
using DevExpress.XtraBars.Ribbon;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls;
using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Common.Massage;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        protected internal IslemTuru BaseIslemTuru;
        protected internal long Id;
        protected internal bool RefreshYapilacak;
        protected DpuDataLayoutControl DataLayoutControl;
        protected IBaseBll Bll;
        protected KartTuru BaseKartTuru;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected bool IsLoaded;
        protected bool KayitSonrasiFormuKapat = true;
        public BaseEditForm()
        {
            InitializeComponent();
        }
        protected internal virtual void Yukle() 
        { 
                    
        }
        protected void EventsLoad()
        {
            //button events
            foreach (BarItem item in ribbonControl.Items)
            {
                item.ItemClick += Buttom_ItemClick;
            }

            //form Events
            Load += BaseEditForm_Load;
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            GuncelNesneOlustur();
            //SablonYukle();
            //ButtonGizleGoster();
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            //güncelleme Yap

        }

        private void Buttom_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item==btnYeni)
            {
                //Yetki Kontrolü
                BaseIslemTuru = IslemTuru.EntityInsert;
                Yukle();
            }
            else if (e.Item==btnKaydet)
            {
                Kaydet(false);
            }
            else if (e.Item==btnGeriAl)
            {
                GeriAl();
            }
            else if (e.Item==btnSil)
            {
                EntityDelete();
            }
            else if (e.Item==btnCikis)
            {
                Close();
            }
        }

        protected virtual void SecimYap(object sender)
        {

        }
        private void EntityDelete()
        {
            throw new NotImplementedException();
        }

        private void GeriAl()
        {
            throw new NotImplementedException();
        }

        private bool Kaydet(bool kapanis)
        {
            bool KayitIslemi()
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (BaseIslemTuru)
                {
                    case IslemTuru.EntityInsert:
                        if (EntityInsert())
                            return KayitSonrasiIslemler();
                        break;
                    case IslemTuru.EntityUpdate:
                        if (EntityUpdate())
                            return KayitSonrasiIslemler();
                        break;
                }
                bool KayitSonrasiIslemler()
                {
                    OldEntity = CurrentEntity;
                    RefreshYapilacak = true;
                    ButtonEnabledDurumu();
                    if (KayitSonrasiFormuKapat)
                        Close();
                    else
                        BaseIslemTuru = BaseIslemTuru == IslemTuru.EntityInsert ? IslemTuru.EntityUpdate : BaseIslemTuru;
                    return true;

                }
                return false;
            }
            
            var result = kapanis ? Messages.KapanisMesaj() : Messages.KayitMesaj();
            switch (result)
            {
                case DialogResult.Yes:
                    return KayitIslemi();
                case DialogResult.No:
                    if (kapanis)
                    {
                        btnKaydet.Enabled = false;
                    }
                        return true;
                    
                case DialogResult.Cancel:
                    return true;

            }
            return false;
        }



        protected virtual bool EntityInsert()
        {
            return ((IBaseGenelBll)Bll).Insert(CurrentEntity);
        }

        protected virtual bool EntityUpdate()
        {
            return ((IBaseGenelBll)Bll).Update(OldEntity, CurrentEntity);
        }
        protected virtual void NesneyiKontrollereBagla()
        {

        }

        protected virtual void GuncelNesneOlustur()
        {

        }

        protected internal virtual void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni,btnKaydet,btnGeriAl,btnSil,OldEntity,CurrentEntity);
            
        }
    }
}