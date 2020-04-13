using DevExpress.XtraBars;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Common.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.Common.Massage;
using System.Windows.Forms;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.RaporForms;
using System.Collections;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls;
using System.Collections.Generic;
using DevExpress.XtraReports;
using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;
using DPU_Soft.PlacementOfExams.UI.Win.Reports.XtraReports;
using System.Linq;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    public partial class RaporSecim : BaseListForm
    {
        private readonly SinavKayitR _sinavKayitBilgileri;
        private readonly IEnumerable<OgrenciBilgileriR> _ogrenbiBilgileri;
        private readonly IEnumerable<SinavSalonBilgileriR> _sinavSalonBilgileri;
        private readonly IEnumerable<GozetmenBilgileriR> _gozetmenBilgileri;
        private readonly long _salonId;
        public RaporSecim(params object[] prm)
        {
            InitializeComponent();
            Bll = new RaporBll();
            ShowItems = new BarItem[] {btnYeniRapor,btnBaskiOnizleme };
            HideItems = new BarItem[] { btnYeni,btnSec,btnFiltrele,btnKolonlar,barFiltrele,barFiltrelemeAciklama,barKolonlar,barKolonlarAciklama};
            btnDuzelt.CreateDropDownMenu(new BarItem[] {btnTasarimDegistir });
            btnYazdir.CreateDropDownMenu(new BarItem[] { btnTabloYazdir });

            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());
            txtYaziciAdi.EditValue = GeneralFunctions.DefaultYazici();
            txtYazdirmaSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaSekli>());
            txtYazdirmaSekli.SelectedItem = YazdirmaSekli.TekTekYazdir.ToName();
            _sinavKayitBilgileri = (SinavKayitR)prm[0];
            _sinavSalonBilgileri = (IEnumerable <SinavSalonBilgileriR>)prm[1];
            _gozetmenBilgileri = (IEnumerable <GozetmenBilgileriR>)prm[2];
            _ogrenbiBilgileri = (IEnumerable <OgrenciBilgileriR>)prm[3];
            _salonId = (long)prm[4];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.RaporTuru;
            base.Navigator = smallNavigator1.Navigator;
        }

        protected override void Listele()
        {
            RowSelect?.ClearSelection();
            Tablo.GridControl.DataSource = ((RaporBll)Bll).List(FilterFunctions.Filter<RaporEntity>(AktifKartlariGoster));
        }
        protected override void Duzelt()
        {
            if (Messages.RaporuTasarimaGonder() != DialogResult.Yes) return;
            {
                Cursor.Current = Cursors.WaitCursor;
                var row = Tablo.GetRow<RaporL>();
                if (row == null) return;
                var entity = (RaporEntity)((RaporBll)Bll).Single(x => x.Id == row.Id);
                var result = ShowRibbonForms<RaporTasarim>.ShowDialogForm(KartTuru.RaporTasarim,entity);
                ShowEditFormDefault(result);
                Cursor.Current = Cursors.Default;

            }
        }

        protected override void ShowEditForm(long id)
        {
            var row = Tablo.GetRow<RaporL>();
            if (row == null) return;
            var entity = (RaporEntity)((RaporBll)Bll).Single(x => x.Id == row.Id);
            var result = ShowEditforms<RaporEditForm>.ShowDialogeditForm(KartTuru.RaporTuru, id, entity.RaporTuru,entity.RaporBolumTuru,entity.Dosya);
            ShowEditFormDefault(result);
        }

        private IList<DpuXtraReport> RaporHazirla()
        {
            var raporlar = new List<DpuXtraReport>();
            var topluRapor = new DpuXtraReport();
            topluRapor.CreateDocument();
            topluRapor.Baslik = "Toplu Rapor";
            topluRapor.PrintingSystem.ContinuousPageNumbering = false;
            foreach (var row in RowSelect.GetSelectedRows())
            {
                var entity = (RaporEntity)((RaporBll)Bll).Single(x => x.Id == row.Id);
                var rapor = entity.Dosya.ByteToStream().StreamToReport();
                ReportDataSource(rapor);
                rapor.CreateDocument();
                switch (txtYazdirmaSekli.Text.GetEnum<YazdirmaSekli>())
                {
                    case YazdirmaSekli.TekTekYazdir:
                        raporlar.Add(rapor);
                        break;
                    case YazdirmaSekli.TopluYazdir:
                        topluRapor.Pages.AddRange(rapor.Pages);
                        break;
                }
            }
            if (topluRapor.Pages.Count == 0) return raporlar;
            raporlar.Add(topluRapor);
            return raporlar;
        }

        private void ReportDataSource(IReport rapor)
        {
            switch (rapor)
            {
                case SalonRaporu rpr:
                    rpr.Sinav_Kayit_Bilgileri.DataSource = _sinavKayitBilgileri;
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenbiBilgileri.Where(x=>x.SinavSalonuId==_salonId).OrderBy(x=>x.SiraNo);
                    rpr.Gozetmen_Bilgileri.DataSource = _gozetmenBilgileri.Where(x=>x.SinavSalonId== _salonId);
                    rpr.Salon_Bilgileri.DataSource = _sinavSalonBilgileri.Where(x =>x.SinavSalonuId== _salonId); 
                    break;
                case SinavRaporu rpr:
                    rpr.Sinav_Kayit_Bilgileri.DataSource = _sinavKayitBilgileri;
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenbiBilgileri.OrderBy(x=>x.OgrenciNo) ;
                    rpr.Gozetmen_Bilgileri.DataSource = _gozetmenBilgileri;
                    rpr.Salon_Bilgileri.DataSource = _sinavSalonBilgileri;
                    break;
                case YoklamaRaporu rpr:
                    rpr.Sinav_Kayit_Bilgileri.DataSource = _sinavKayitBilgileri;
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenbiBilgileri.Where(x => x.SinavSalonuId == _salonId).OrderBy(x=>x.SiraNo);
                    rpr.Gozetmen_Bilgileri.DataSource = _gozetmenBilgileri.Where(x => x.SinavSalonId == _salonId);
                    rpr.Salon_Bilgileri.DataSource = _sinavSalonBilgileri.Where(x => x.SinavSalonuId == _salonId);
                    break;
            }
        }

        protected override void Yazdir()
        {
            if (Messages.EvetSeciliEvetHayir("Rapor Yazdırılmak Üzere Seçtiğiniz Yazıcıya Gönderilecektir. Onaylıyor musunuz?", "Yazdırma Onayı") != DialogResult.Yes) return;
            var raporlar = RaporHazirla();
            for (int i = 0; i < txtYazdirilacakAdet.Value; i++)
            {
                raporlar.ForEach(x => x.Print(txtYaziciAdi.Text));
            }
        }

        protected override void BaskiOnizleme()
        {
            var raporlar = RaporHazirla();
            raporlar.ForEach(x=>ShowRibbonForms<RaporOnizleme>.ShowForm(false, x.PrintingSystem, x.Baslik));

        }

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.Button_ItemClick(sender, e);

            void RaporOlustur(KartTuru raporTuru, RaporBolumTuru raporBolumTuru, XtraReport rapor)
            {
                if (Messages.RaporuTasarimaGonder() != DialogResult.Yes) return;

                Cursor.Current = Cursors.WaitCursor;

                var entity = new RaporEntity
                {
                    Kod = ((RaporBll)Bll).YeniKodVer(x => x.RaporTuru == raporTuru),
                    RaporTuru = raporTuru,
                    RaporBolumTuru = raporBolumTuru,
                    RaporAdi = raporTuru.ToName(),
                    Dosya = rapor.ReportToStream().GetBuffer(),
                    durum=true

                };

                var result = ShowRibbonForms<RaporTasarim>.ShowDialogForm(KartTuru.RaporTasarim, entity);
                ShowEditFormDefault(result);

                Cursor.Current = Cursors.Default;
            }

            if (e.Item == btnYeniRapor)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item==btnBosRapor)
            {

            }
            else if (e.Item == btnSalonListesi)
            {
                RaporOlustur(KartTuru.SalonListesiRaporu,RaporBolumTuru.SinavRaporlari,new SalonRaporu());
            }
            else if (e.Item == btnSinavListesi)
            {
                RaporOlustur(KartTuru.SinavListesiRaporu, RaporBolumTuru.SinavRaporlari, new SinavRaporu());
            }
            else if (e.Item == btnYoklamaListesi)
            {
                RaporOlustur(KartTuru.YoklamaListesiRaporu, RaporBolumTuru.SinavRaporlari, new YoklamaRaporu());
            }
        }
    }
}