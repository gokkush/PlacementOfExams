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
using System.Linq;
using DevExpress.XtraBars.Navigation;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using DPU_Soft.BLL.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Base;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DevExpress.XtraLayout.Utils;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.SinavKayitForms
{
    public partial class SinavKayitEditForm : BaseEditForm
    {
        public SinavKayitEditForm()
        {
            InitializeComponent();
            DataLayoutControls = new[] {dpuDataLayoutControlDis, dpuDataLayoutControlGenelBilgiler };
            Bll = new SinavKayitBll(dpuDataLayoutControlGenelBilgiler);
            BaseKartTuru = KartTuru.SinavKayit;
            EventsLoad();
            ShowItems = new BarItem[] { btnYazdir};
            HideItems = new BarItem[] {btnSil };
            txtSinavTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<SinavTuru>());
            btnYazdir.Caption = "Raporlar";
            KayitSonrasiFormuKapat = false;
            btnYazdir.Enabled = false;
        }
        protected override void ButtonGizleGoster()
        {
            base.ButtonGizleGoster();
            if (tglListe.IsOn==true&&BaseIslemTuru != IslemTuru.EntityInsert)
            {
                lblSalonYazi1.Visible = true;
                lblSalonYazi.Visibility=LayoutVisibility.Always;
                lblSalonYazi1.Visible = true;
                lblSalonListe.Visibility = LayoutVisibility.Always;
                pageGenelBilgiler.Show();
                pageSalonOlustur.PageVisible = false;
                pageGozetmen.PageVisible = false;
                pageSalonGozetmen.PageVisible = false;
                pageOgrenciListesi.PageVisible=false;
                btnYazdir.Enabled = true;
                BagliTabloYukle();
            }
        }
        protected override void Yazdir()
        {
            var sinavKayitBilgileri = ((SinavKayitBll)Bll).SingleDetail(x => x.Id == Id);
            var ogrenciBilgileri = ogrenciListesiTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<OgrenciBilgileriR>();
            var salonBilgileri = sinavSalonBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<SinavSalonBilgileriR>();
            var gozetmenBilgileri= gozetmenBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<GozetmenBilgileriR>();
            ShowListforms<RaporSecim>.ShowDialogListForm(KartTuru.RaporTuru, true,sinavKayitBilgileri,salonBilgileri,gozetmenBilgileri,ogrenciBilgileri, txtSalonListesi1.GetColumnValue("SinavSalonuId"));
        }

        public SinavKayitEditForm(params object[] prm):this()
        {
            if (prm[0] is bool)
                FarkliSubeIslemi = (bool)prm[0];
            
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SinavKayitS() : ((SinavKayitBll)Bll).Single(FilterFunctions.Filter<SinavKayitEntity>(Id));
            if (BaseIslemTuru==IslemTuru.EntityInsert&&tglListe.IsOn==false)
            {
                pageSalonOlustur.PageVisible = false;
                pageGozetmen.PageVisible = false;
                pageOgrenciListesi.PageVisible = false;
                pageSalonGozetmen.PageVisible = false;
            }

                
            NesneyiKontrollereBagla();

                BagliTabloYukle();
               // TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SinavKayitBll)Bll).YeniKodVer(x=>x.SubeId==AnaForm.SubeId&&x.DonemId==AnaForm.DonemId);
            
        }

      /*  protected override void BagliTabloYukle()
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
        */

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SinavKayitS)OldEntity;
            txtKod.Text = entity.Kod;
            txtDers.Id = entity.DersId;
            txtDers.Text = entity.DersAdi;
            txtSinavTuru.SelectedItem = entity.SinavTuru.ToName();
            txtAciklama.Text = entity.Aciklama;
            tglListe.IsOn = entity.ListeOlustu;
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
                DonemId = AnaForm.DonemId,
                SubeId = AnaForm.SubeId,
                Aciklama = AnaForm.DonemAdi.Trim().ToString() + " " + txtSinavTuru.Text.Trim().ToString(),//txtAciklama.Text,
                SinavTuru = txtSinavTuru.Text.GetEnum<SinavTuru>(),
                ListeOlustu = tglListe.IsOn,
                durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();
        
        }

        protected override bool EntityInsert()
        {
            var result = ((SinavKayitBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == x.DonemId)&&BagliTabloKaydet();

            if (result&&!KayitSonrasiFormuKapat)
            {
                BagliTabloYukle();
               // TabloYukle();
            }
            pageSalonOlustur.PageVisible = true;
            pageGozetmen.PageVisible = true;
            pageOgrenciListesi.PageVisible = true;
            pageSalonGozetmen.PageVisible = true;
            BaseIslemTuru = IslemTuru.EntityUpdate;
            return result;
        }
        protected override bool EntityUpdate()
        {
            var result = ((SinavKayitBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == x.DonemId)&&BagliTabloKaydet();
            if (result&&!KayitSonrasiFormuKapat)
            {
                BagliTabloYukle();
                //TabloYukle();
            }
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
        protected override void BagliTabloYukle()
        {

                ogrenciListesiTable.OvnerForm = this;
                ogrenciListesiTable.Yukle();
                gozetmenBilgileriTable.OvnerForm = this;
                gozetmenBilgileriTable.Yukle();
                sinavSalonBilgileriTable.OvnerForm = this;
                sinavSalonBilgileriTable.Yukle();
            var SalonSource = sinavSalonBilgileriTable.Tablo.DataController.ListSource;
            var SalonEntities = SalonSource.Cast<SinavSalonBilgileriL>().Where(x => !x.Delete).ToList();
            if (SalonEntities != null)
            {

                txtSalonListesi1.Properties.DataSource = SalonEntities;
                txtSalonListesi1.Properties.ValueMember = "id";
                txtSalonListesi1.Properties.DisplayMember = "SalonAdi";
                txtSalonListesi1.ItemIndex = 0;
            }
                bool TabloValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }
            if (TabloValueChanged(gozetmenBilgileriTable))
            {
                var rowhandle = gozetmenBilgileriTable.Tablo.FocusedRowHandle;
                gozetmenBilgileriTable.Yukle();
                gozetmenBilgileriTable.Tablo.FocusedRowHandle = rowhandle;
            }
            if (TabloValueChanged(ogrenciListesiTable))
            {
                var rowhandle = ogrenciListesiTable.Tablo.FocusedRowHandle;
                ogrenciListesiTable.Yukle();
                ogrenciListesiTable.Tablo.FocusedRowHandle = rowhandle;
            }
            if (TabloValueChanged(sinavSalonBilgileriTable))
            {
                var rowhandle = sinavSalonBilgileriTable.Tablo.FocusedRowHandle;
                sinavSalonBilgileriTable.Yukle();
                sinavSalonBilgileriTable.Tablo.FocusedRowHandle = rowhandle;
            }
            Toplamlar();
        }
        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (gozetmenBilgileriTable.TablevalueChanged) return true;
                if (ogrenciListesiTable.TablevalueChanged) return true;
                if (sinavSalonBilgileriTable.TablevalueChanged) return true;
                return false;
            }
            if (gozetmenBilgileriTable.TablevalueChanged || sinavSalonBilgileriTable.TablevalueChanged || ogrenciListesiTable.TablevalueChanged)
                Toplamlar();

            if (FarkliSubeIslemi)
               Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil);
            else
               Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil,OldEntity,CurrentEntity,TableValueChanged());
        }

        protected override bool BagliTabloKaydet()
        {
            if (!sinavSalonBilgileriTable.Kaydet())
            {
                return false;
            }
            if (!ogrenciListesiTable.Kaydet())
            {
                return false;
            }
            if (!gozetmenBilgileriTable.Kaydet())
            {
                return false;
            }
            return true;
        }

        private void Toplamlar()
        {
            var gozetmenSayisi = gozetmenBilgileriTable.Tablo.DataRowCount;
            var ogrenciSayisi = ogrenciListesiTable.Tablo.DataRowCount;//DataController.ListSource.Cast<SinavSalonBilgileriL>().Where(x => x.Delete).Sum(x => x.SalonKapasitesi);
            var toplamSalonKapasitesi = sinavSalonBilgileriTable.Tablo.DataController.ListSource.Cast<SinavSalonBilgileriL>().Where(x => !x.Delete).Sum(x => x.SalonKapasitesi);
            var toplamGozetmenSayisi = sinavSalonBilgileriTable.Tablo.DataController.ListSource.Cast<SinavSalonBilgileriL>().Where(x => !x.Delete).Sum(x => x.GozetmenSayisi);
            txtsalonKapasiteToplami.Text = toplamSalonKapasitesi.ToString() ;
            txtOlmasiGerekenGozetmenSayisi.Text = toplamGozetmenSayisi.ToString();
            txtOgrenciSayisi.Text = ogrenciSayisi.ToString();
            txtGorevlendirilenGozetmenSayisi.Text = gozetmenSayisi.ToString();
            if (ogrenciSayisi > toplamSalonKapasitesi)
            {
                lblOgrenciDurum.Text = "Seçilen salonların kapasitesi yetersizdir.";
                lblOgrenciDurum.ForeColor = Color.Red;
                btnSalonaGozetmenAta.Enabled = false;
                btnOgrenciAta.Enabled = false;
                txtGozetmenListesi.Enabled = false;
                txtSalonListesi.Enabled = false;
            }
                
            else
            {
                lblOgrenciDurum.Text = "Geçerli";
                lblOgrenciDurum.ForeColor = Color.Green;
                btnSalonaGozetmenAta.Enabled = true;
                btnOgrenciAta.Enabled = false;
                txtGozetmenListesi.Enabled = true;
                txtSalonListesi.Enabled = true;
            }
            if (toplamGozetmenSayisi > gozetmenSayisi)
            {
                lblGozetmenDurum.Text = "Seçilen Gözetmenlerin Sayısı yetersizdir.";
                lblGozetmenDurum.ForeColor = Color.Red;
                btnSalonaGozetmenAta.Enabled = false;
                btnOgrenciAta.Enabled = false;
                txtGozetmenListesi.Enabled = false;
                txtSalonListesi.Enabled = false;
            }

            else
            {
                lblGozetmenDurum.Text = "Geçerli";
                lblGozetmenDurum.ForeColor = Color.Green;
                btnSalonaGozetmenAta.Enabled = true;
                btnOgrenciAta.Enabled = false;
                txtGozetmenListesi.Enabled = true;
                txtSalonListesi.Enabled = true;
            }
            
        }
        
        private void ListeDoldur()
        {
            var GozetmenSource = gozetmenBilgileriTable.Tablo.DataController.ListSource;
            var GozetmenEntities = GozetmenSource.Cast<GozetmenBilgileriL>().Where(x => !x.Delete&& x.SinavSalonId==null).OrderBy(x => x.id).ToList();
            if (GozetmenEntities.Count>0)
            {
                txtGozetmenListesi.Properties.DataSource = GozetmenEntities;
                txtGozetmenListesi.Properties.ValueMember = "id";
                txtGozetmenListesi.Properties.DisplayMember = "GozetmenAdi";
                txtGozetmenListesi.ItemIndex = 0;
            }
            else
            {
                txtGozetmenListesi.Properties.DataSource = null;
                btnSalonaGozetmenAta.Enabled = false;
            }
                

            var SalonSource = sinavSalonBilgileriTable.Tablo.DataController.ListSource;
            var SalonEntities = SalonSource.Cast<SinavSalonBilgileriL>().Where(x => !x.Delete).ToList();
            if (SalonEntities!=null)
            {
            txtSalonListesi.Properties.DataSource = SalonEntities;
            txtSalonListesi.Properties.ValueMember = "id";
            txtSalonListesi.Properties.DisplayMember = "SalonAdi";
            txtSalonListesi.ItemIndex = 0;
                txtSalonListesi1.Properties.DataSource = SalonEntities;
                txtSalonListesi1.Properties.ValueMember = "id";
                txtSalonListesi1.Properties.DisplayMember = "SalonAdi";
                txtSalonListesi1.ItemIndex = 0;
            }
            else
            {
                txtSalonListesi.Properties.DataSource = null;
                btnSalonaGozetmenAta.Enabled = false;
            }
            if (lblGozetmenDurum.Text == "Geçerli" && lblOgrenciDurum.Text == "Geçerli" && txtGozetmenListesi.Properties.DataSource == null)
                btnOgrenciAta.Enabled = true;
            else
                btnOgrenciAta.Enabled = false;
        }
       

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page==pageGenelBilgiler)
            {
                txtDers.Focus();
               // ListeDoldur();

            }
            else if (e.Page == pageSalonOlustur)
            {
                ListeDoldur();

            }
            else if (e.Page==pageGozetmen)
            {
                ListeDoldur();
            }
            else if (e.Page==pageOgrenciListesi)
            {
                ListeDoldur();
            }

            #region EgerSonradanEklenirse

            /*  else if (e.Page == pageSalonGozetmen)
              {
                  if (pageSalonGozetmen.Controls.Count == 0)
                  {
                      _sinavSalonBilgileriTablo = new SinavSalonBilgileriTable().AddTable(this);
                      pageSalonGozetmen.Controls.Add(_sinavSalonBilgileriTablo);
                      //layoutControlGroupSalonBilgileri.LayoutControlInsert(_sinavSalonBilgileriTablo,0,0,0,0);
                      _sinavSalonBilgileriTablo.Yukle();
                  }

                  _sinavSalonBilgileriTablo.Tablo.GridControl.Focus();
              }

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
              }*/

            #endregion      
        
        }

        private void btnSalonaGozetmenAta_Click(object sender, EventArgs e)
        {
            GozetmeneSalonAta();
        }

        private void GozetmeneSalonAta()
        {
            sinavSalonBilgileriTable.Kaydet();
            var gozetmenEntity = gozetmenBilgileriTable.Tablo.DataController.ListSource.Cast<GozetmenBilgileriL>().FirstOrDefault(x => !x.Delete && x.GozetmenId == (long)txtGozetmenListesi.GetColumnValue("GozetmenId"));
            gozetmenEntity.SinavSalonId = (long)txtSalonListesi.GetColumnValue("SinavSalonuId");
            gozetmenEntity.Update = true;
            gozetmenBilgileriTable.Kaydet();
            ListeDoldur();
        }

        private void OgrenciAta()
        {
            Random rnd = new Random();
            var source = sinavSalonBilgileriTable.Tablo.DataController.ListSource;
            var entities = source.Cast<SinavSalonBilgileriL>().Where(x => !x.Delete).ToList();
            foreach (var entity in entities)
            {

                for (int i = 0; i < entity.SalonKapasitesi; i++)
                {
                    var OgrenciSource = ogrenciListesiTable.Tablo.DataController.ListSource;
                    var OgrenciEntities = OgrenciSource.Cast<OgrenciBilgileriL>().Where(x => !x.Delete&&x.SinavSalonuId==null).ToList();
                    if (OgrenciEntities.Count == 0) continue;
                    int secilenOgrenci = rnd.Next(OgrenciEntities.Count);
                    OgrenciEntities[secilenOgrenci].SinavSalonuId = entity.SinavSalonuId;
                    OgrenciEntities[secilenOgrenci].SiraNo = i+1;
                    OgrenciEntities[secilenOgrenci].Update = true;
                }

            }
           // ogrenciListesiTable.Kaydet();
            tglListe.IsOn = true;
            
        }
        private void btnOgrenciAta_Click(object sender, EventArgs e)
        {
            OgrenciAta();
            btnKaydet.PerformClick();
            ButtonGizleGoster();
        }
    }

    }
     