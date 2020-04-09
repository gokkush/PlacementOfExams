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

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.SinavKayitForms
{
    public partial class SinavKayitEditForm : BaseEditForm
    {
        private string _sinavAdi;
        private List<SinavSalonBilgileriL> _sinavSalonlari;
        private List<GozetmenBilgileriL> _gozetmenler;
        private bool _listeOlustu;
        private bool _gozetmenGorevlendirilmesiTamamlandi;

        public SinavKayitEditForm()
        {
            
            InitializeComponent();
            DataLayoutControls = new[] {dpuDataLayoutControlDis, dpuDataLayoutControlGenelBilgiler };
            Bll = new SinavKayitBll(dpuDataLayoutControlGenelBilgiler);
            BaseKartTuru = KartTuru.SinavKayit;
            EventsLoad();
            
            HideItems = new BarItem[] {btnYeni,btnSil };
            txtSinavTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<SinavTuru>());
            btnYazdir.Caption = "Sınav Kayıtları";
            _sinavSalonlari = new List<SinavSalonBilgileriL>();
            _gozetmenler = new List<GozetmenBilgileriL>();
            foreach (Control control in Controls)
            {
                    switch (control)
                    {
                        case SimpleButton btn:
                        {
                            if (btn == btnSalonaGozetmenAta)
                            {
                                btn.Click += Control_Click;
                            }
                        }
                            break;
                    }
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            OgrenciAta();
            Cursor.Current = Cursors.Default;           
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
            {
                //BagliTabloYukle();
                TabloYukle();
            }
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
            _sinavAdi = entity.SinavAdi;
            txtKod.Text = entity.Kod;
            txtDers.Id = entity.DersId;
            txtDers.Text = entity.DersAdi;
            txtSinavTuru.SelectedItem = entity.SinavTuru.ToName();
            txtAciklama.Text = entity.Aciklama;
            _listeOlustu = entity.ListeOlustu;
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
                SinavAdi = BaseIslemTuru == IslemTuru.EntityInsert ? txtSinavTuru.SelectedItem + " - " + txtDers.Text.ToString() + " - " + AnaForm.SubeAdi + " - " + AnaForm.DonemAdi : _sinavAdi,
                Aciklama = txtAciklama.Text,
                SinavTuru = txtSinavTuru.Text.GetEnum<SinavTuru>(),
                ListeOlustu = _listeOlustu,
                durum = tglDurum.IsOn

            };

            ButtonEnabledDurumu();
        
        }

        protected override bool EntityInsert()
        {
            var result = ((SinavKayitBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == x.DonemId)&&BagliTabloKaydet();

            if (result)
            {
                //BagliTabloYukle();
                TabloYukle();
            }
            return result;
        }
        protected override bool EntityUpdate()
        {
            var result = ((SinavKayitBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == x.DonemId)&&BagliTabloKaydet();
            if (result)
            {
               // BagliTabloYukle();
                TabloYukle();
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
        protected override void TabloYukle()
        {
            ogrenciListesiTable.OvnerForm = this;
            ogrenciListesiTable.Yukle();
            gozetmenBilgileriTable.OvnerForm = this;
            gozetmenBilgileriTable.Yukle();
            sinavSalonBilgileriTable.OvnerForm = this;
            sinavSalonBilgileriTable.Yukle();

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
                cmbGozetmen.Enabled = false;
                cmbSalon.Enabled = false;
            }
                
            else if(!_listeOlustu)
            {
                lblOgrenciDurum.Text = "Geçerli";
                lblOgrenciDurum.ForeColor = Color.Green;
                btnSalonaGozetmenAta.Enabled = true;
                btnOgrenciAta.Enabled = false;
                cmbGozetmen.Enabled = true;
                cmbSalon.Enabled = true;
            }
            if (toplamGozetmenSayisi > gozetmenSayisi)
            {
                lblGozetmenDurum.Text = "Seçilen Gözetmenlerin Sayısı yetersizdir.";
                lblGozetmenDurum.ForeColor = Color.Red;
                btnSalonaGozetmenAta.Enabled = false;
                btnOgrenciAta.Enabled = false;
                cmbGozetmen.Enabled = false;
                cmbSalon.Enabled = false;
            }

            else if(!_listeOlustu)
            {
                lblGozetmenDurum.Text = "Geçerli";
                lblGozetmenDurum.ForeColor = Color.Green;
                btnSalonaGozetmenAta.Enabled = true;
                btnOgrenciAta.Enabled = false;
                cmbGozetmen.Enabled = true;
                cmbSalon.Enabled = true;
            }
        }




        private void OgrenciAta()
        {

        }
        private bool GozetmenGorevlendirilmesiTamamlandi()
        {
            var source = gozetmenBilgileriTable.Tablo.DataController.ListSource;
            var entities = source.Cast<GozetmenBilgileriL>().Where(x => !x.Delete&&x.SinavSalonId==null).ToList();
            return _gozetmenGorevlendirilmesiTamamlandi = entities.Count > 0;
        }

        private void ListeDoldur()
        {
            if (!_listeOlustu)
            {
                var source = sinavSalonBilgileriTable.Tablo.DataController.ListSource;
                var entities = source.Cast<SinavSalonBilgileriL>().Where(x => !x.Delete).ToList();
                _sinavSalonlari.Clear();
                foreach (var entity in entities)
                {
                    for (int i = 0; i < entity.GozetmenSayisi; i++)
                    {
                        var row = new SinavSalonBilgileriL
                        {
                            id = entity.id,
                            SalonAdi = entity.SalonAdi,
                            SinavSalonu_Id = entity.SinavSalonu_Id,
                            Insert = true
                        };
                        _sinavSalonlari.Add(row);
                    }

                }
                cmbSalon.Properties.Items.Clear();
                for (int i = 0; i < _sinavSalonlari.Count(); i++)
                {
                    cmbSalon.Properties.Items.Add(_sinavSalonlari[i].SalonAdi);
                }
                if (cmbSalon.Properties.Items.Count > 0)
                {
                    cmbSalon.SelectedIndex = 0;
                }

                var source2 = gozetmenBilgileriTable.Tablo.DataController.ListSource;
                var entities2 = source2.Cast<GozetmenBilgileriL>().Where(x => !x.Delete).OrderBy(x => x.id).ToList();
                _gozetmenler.Clear();
                foreach (var entity in entities2)
                {
                    if (entity.SinavSalonId!=null)
                    {
                        var row = new GozetmenBilgileriL
                        {
                            id = entity.id,
                            GozetmenId = entity.GozetmenId,
                            GozetmenAdi = entity.GozetmenAdi+" (Salona Görevlendirildi)",
                            SinavKayitId = entity.SinavKayitId,
                            SinavSalonId = entity.SinavSalonId,
                            GorevlendirmeSayisi = entity.GorevlendirmeSayisi,
                            Insert = true
                        };
                        _gozetmenler.Add(row);
                    }
                    else
                    {
                        var row = new GozetmenBilgileriL
                        {
                            id = entity.id,
                            GozetmenId = entity.GozetmenId,
                            GozetmenAdi = entity.GozetmenAdi,
                            SinavKayitId = entity.SinavKayitId,
                            SinavSalonId = entity.SinavSalonId,
                            GorevlendirmeSayisi = entity.GorevlendirmeSayisi,
                            Insert = true
                        };
                        _gozetmenler.Add(row);
                    }

                }
                if (cmbGozetmen.Properties.Items.Count > 0)
                {
                    cmbGozetmen.SelectedIndex = 0;
                }
                cmbGozetmen.Properties.Items.Clear();
                for (int i = 0; i < _gozetmenler.Count(); i++)
                {
                    cmbGozetmen.Properties.Items.Add(_gozetmenler[i].GozetmenAdi);
                }
            }
        }

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page==pageGenelBilgiler)
            {
                txtDers.Focus();
            }
            else if (e.Page == pageSalonOlustur)
            {
                ListeDoldur();
                if (!GozetmenGorevlendirilmesiTamamlandi())
                {
                    btnOgrenciAta.Enabled = true;
                }

            }
            else if (e.Page==pageGozetmen)
            {
                gozetmenBilgileriTable.Tablo.Columns[2].Visible = false;
                gozetmenBilgileriTable.Tablo.Columns[1].Visible = true;
                gozetmenBilgileriTable.Tablo.Focus();
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
            gozetmenBilgileriTable.Tablo.FocusedRowHandle = cmbGozetmen.SelectedIndex;
            gozetmenBilgileriTable.Tablo.SetRowCellValue(cmbGozetmen.SelectedIndex, gozetmenBilgileriTable.Tablo.Columns[2], (long)_sinavSalonlari[cmbSalon.SelectedIndex].SinavSalonu_Id);
            //gozetmenBilgileriTable.Tablo.PostEditor(); //save the cell value to a data source 
            //gozetmenBilgileriTable.Tablo.UpdateCurrentRow();
            gozetmenBilgileriTable.Kaydet();
            gozetmenBilgileriTable.btnTabloYenile.PerformClick();
            ButtonEnabledDurumu();
            cmbGozetmen.Focus();
            cmbGozetmen.SelectedText = "";
            ListeDoldur();

            /*
            var gozetmenEntity = gozetmenBilgileriTable.Tablo.DataController.ListSource.Cast<GozetmenBilgileriL>().FirstOrDefault(x => !x.Delete && x.GozetmenId == _gozetmenler[cmbGozetmen.SelectedIndex].GozetmenId);
            gozetmenEntity.SinavSalonId = _sinavSalonlari[cmbSalon.SelectedIndex].SinavSalonu_Id;
            gozetmenEntity.Update = true;
            ButtonEnabledDurumu();
            ListeDoldur();
             */
        }

        private void btnOgrenciAta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hayıır");
        }
    }

    }
     