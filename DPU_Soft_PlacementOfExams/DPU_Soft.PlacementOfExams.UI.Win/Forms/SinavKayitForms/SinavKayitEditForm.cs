using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.Common.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms;
using DevExpress.XtraEditors;
using System;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Base;
using System.Linq;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using DevExpress.XtraBars.Navigation;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.SinavKayitFormTable;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.SinavKayitForms
{
    public partial class SinavKayitEditForm : BaseEditForm
    {
        private BaseTablo _sinavSalonBilgileriTablo;
        private BaseTablo _gozetmenBilgileriTablo;
        private string _sinavAdi;
        public SinavKayitEditForm()
        {
            InitializeComponent();
            DataLayoutControls = new[] {dpuDataLayoutControlDis, dpuDataLayoutControlGenelBilgiler };
            Bll = new SinavKayitBll(dpuDataLayoutControlGenelBilgiler);
            BaseKartTuru = KartTuru.SinavKayit;
            EventsLoad();

            HideItems = new BarItem[] {btnYeni };
            ShowItems = new BarItem[] { btnExceldenAl };
            txtSinavTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<SinavTuru>());
            btnYazdir.Caption = "Sınav Kayıtları";

        }

        public SinavKayitEditForm(params object[] prm):this()
        {
            if (prm[0] is bool)
                FarkliSubeIslemi = (bool)prm[0];
            
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SinavKayitS() : ((SinavKayitBll)Bll).Single(FilterFunctions.Filter<SinavKayitEntity>(Id));
            NesneyiKontrollereBagla();
            BagliTabloYukle();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SinavKayitBll)Bll).YeniKodVer(x=>x.SubeId==AnaForm.SubeId&&x.DonemId==AnaForm.DonemId);
        }

        protected override void BagliTabloYukle()
        {
            bool TabloValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }
            if (_sinavSalonBilgileriTablo != null)
            {
                _sinavSalonBilgileriTablo.Yukle();
            }
            else if (_gozetmenBilgileriTablo != null)
            {
                _gozetmenBilgileriTablo.Yukle();
            }

        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SinavKayitS)OldEntity;
            _sinavAdi = entity.SinavAdi;
            txtKod.Text = entity.Kod;
            txtDers.Id = entity.DersId;
            txtDers.Text = entity.DersAdi;
            txtSinavTuru.SelectedItem = entity.SinavTuru.ToName();
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.durum;
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            GuncelNesneOlustur();
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new SinavKayitEntity
            {
                Id = Id,
                Kod = txtKod.Text,
                DersId = (long)txtDers.Id,
                DersAdi = txtDers.Text,
                DonemId = AnaForm.DonemId,
                SubeId = AnaForm.SubeId,
                SinavAdi = BaseIslemTuru == IslemTuru.EntityInsert ? txtSinavTuru.SelectedItem+" - "+ txtDers.Text.ToString() + " - " + AnaForm.SubeAdi + " - " + AnaForm.DonemAdi : _sinavAdi,
                Aciklama = txtAciklama.Text,
                SinavTuru = txtSinavTuru.Text.GetEnum<SinavTuru>(),
                durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();
        
        }

        protected override bool EntityInsert()
        {
            var result = ((SinavKayitBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == x.DonemId)&&BagliTabloKaydet();

            if (result) BagliTabloYukle();
            return result;
        }
        protected override bool EntityUpdate()
        {
            var result = ((SinavKayitBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == x.DonemId)&&BagliTabloKaydet();
            if (result) BagliTabloYukle();
            return result;
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
                return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtDers)
                    sec.Sec(txtDers);
            }

        }
        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (_sinavSalonBilgileriTablo != null && _sinavSalonBilgileriTablo.TablevalueChanged) return true;
                if (_gozetmenBilgileriTablo != null && _gozetmenBilgileriTablo.TablevalueChanged) return true;
                return false;
            }

            if (FarkliSubeIslemi)
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil);
            else
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil,OldEntity,CurrentEntity,TableValueChanged());
        }

        protected override bool BagliTabloKaydet()
        {
            if (_sinavSalonBilgileriTablo!=null&& !_sinavSalonBilgileriTablo.Kaydet())
            {
                return false;
            }
            if (_gozetmenBilgileriTablo != null && !_gozetmenBilgileriTablo.Kaydet())
            {
                return false;
            }
            return true;
        }

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page==pageGenelBilgiler)
            {
                txtDers.Focus();
            }
            //else if (e.Page == pageSalonGozetmen)
            //{
            //    if (pageSalonGozetmen.Controls.Count == 0)
            //    {
            //        _sinavSalonBilgileriTablo = new SinavSalonBilgileriTable().AddTable(this);
            //        pageSalonGozetmen.Controls.Add(_sinavSalonBilgileriTablo);
            //        //layoutControlGroupSalonBilgileri.LayoutControlInsert(_sinavSalonBilgileriTablo,0,0,0,0);
            //        _sinavSalonBilgileriTablo.Yukle();
            //    }

            //    _sinavSalonBilgileriTablo.Tablo.GridControl.Focus();
            //}

            else if (e.Page == pageSalonGozetmen)
            {
                if (layoutControlGroupSalonBilgileri.Items.Count == 0)
                {
                    _sinavSalonBilgileriTablo = new SinavSalonBilgileriTable().AddTable(this);
                    //pageSalonGozetmen.Controls.Add(_sinavSalonBilgileriTablo);
                    layoutControlGroupSalonBilgileri.LayoutControlInsert(_sinavSalonBilgileriTablo, 0, 0, 0, 0);
                    _sinavSalonBilgileriTablo.Yukle();
                }

                _sinavSalonBilgileriTablo.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageGozetmen)
            {
                if (layoutControlGroupGozeetmenBilgileri.Items.Count == 0)
                {
                    _gozetmenBilgileriTablo = new GozetmenBilgileriTable().AddTable(this);
                    //pageSalonGozetmen.Controls.Add(_sinavSalonBilgileriTablo);
                    layoutControlGroupGozeetmenBilgileri.LayoutControlInsert(_gozetmenBilgileriTablo, 0, 0, 0, 0);
                    _gozetmenBilgileriTablo.Yukle();
                }

                _gozetmenBilgileriTablo.Tablo.GridControl.Focus();
            }
        }
    }
}