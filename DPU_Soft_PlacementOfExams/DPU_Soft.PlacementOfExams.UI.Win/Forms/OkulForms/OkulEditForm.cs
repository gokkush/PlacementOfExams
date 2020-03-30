using System;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;
<<<<<<< HEAD
=======
using DevExpress.XtraEditors;
>>>>>>> yandal

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.OkulForms
{
    public partial class OkulEditForm : BaseEditForm
    {
        public OkulEditForm()
        {
            InitializeComponent();
            DataLayoutControl = dpuDataLayoutControl;
            Bll = new OkulBll(dpuDataLayoutControl);
            BaseKartTuru = KartTuru.Okul;
            EventsLoad();

        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OkulS():((OkulBll)Bll).Single(FilterFunctions.Filter<OkulEntity>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
<<<<<<< HEAD
=======
            Id = BaseIslemTuru.IdOlustur(OldEntity);
>>>>>>> yandal
            txtKod.Text = ((OkulBll)Bll).YeniKodVer();
            txtOkulAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OkulS)OldEntity;

            txtKod.Text = entity.Kod;
            txtOkulAdi.Text = entity.FakulteAdi;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
<<<<<<< HEAD
=======
            txtUnvAdi.Id = entity.UniversiteId;
            txtUnvAdi.Text = entity.UniversiteAdi;
>>>>>>> yandal
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new OkulEntity
            {
<<<<<<< HEAD
                id = Id,
=======
                Id = Id,
>>>>>>> yandal
                Kod = txtKod.Text,
                FakulteAdi = txtOkulAdi.Text,
                IlId = Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id),
<<<<<<< HEAD
=======
                UniversiteId= Convert.ToInt64(txtUnvAdi.Id),
>>>>>>> yandal
                Aciklama = txtAciklama.Text,
                durum=tglDurum.IsOn                                         

            };

            ButtonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
<<<<<<< HEAD
            base.SecimYap(sender);
=======
            if (!(sender is ButtonEdit))
                return;
            using (var sec= new SelectFunctions())
            {
                if (sender == txtIl)
                    sec.Sec(txtIl);
                else if (sender == txtIlce)
                    sec.Sec(txtIlce, txtIl);
                else if (sender == txtUnvAdi)
                    sec.Sec(txtUnvAdi);
            }
            
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtIl) return;
            txtIl.ControlEnabledChange(txtIlce);
>>>>>>> yandal
        }

    }
}