using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.Common.Functions;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using System;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    public partial class TabloDokumParametreleri : BaseEditForm
    {
        private DokumSekli _dokumSekli;
        private readonly string _raporBaslik;

        public TabloDokumParametreleri(params object[] prm)
        {
            InitializeComponent();
            DataLayoutControl = dpuDataLayoutControl2;
            HideItems = new BarItem[] {btnYeni, btnKaydet, btnGeriAl, btnSil };
            ShowItems = new BarItem[] {btnBaskiOnizleme,btnYazdir };
            EventsLoad();

            _raporBaslik = prm[0].ToString();
        }

        protected internal override void Yukle()
        {
            txtRaporBasligi.Text = _raporBaslik;
            txtBaslikEkle.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtRaporKagitSigdir.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<RaporuKagidaSigdir>());
            txtYazidirmaYonu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaYonu>());
            txtYatayCizgiler.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtDikeyCizgiler.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtSutunBasliklariGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());

            txtBaslikEkle.SelectedItem= EvetHayir.Evet.ToName();
            txtRaporKagitSigdir.SelectedItem = RaporuKagidaSigdir.YaziBoyutunuKücülterekSigdir.ToName();
            txtYazidirmaYonu.SelectedItem = YazdirmaYonu.Otomatik.ToName();
            txtYatayCizgiler.SelectedItem = EvetHayir.Evet.ToName();
            txtDikeyCizgiler.SelectedItem= EvetHayir.Evet.ToName();
            txtSutunBasliklariGoster.SelectedItem= EvetHayir.Evet.ToName();
            txtYaziciAdi.EditValue = GeneralFunctions.DefaultYazici();
        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new DokumParametreleri
            {
                RaporBaslik = txtRaporBasligi.Text,
                BaslikEkle = txtBaslikEkle.Text.GetEnum<EvetHayir>(),
                RaporKagidaSigdirma = txtRaporKagitSigdir.Text.GetEnum<RaporuKagidaSigdir>(),
                YazdirmaYonu = txtYazidirmaYonu.Text.GetEnum<YazdirmaYonu>(),
                YatayCizgileriGoster = txtYatayCizgiler.Text.GetEnum<EvetHayir>(),
                DikeyCizgileriGoster = txtDikeyCizgiler.Text.GetEnum<EvetHayir>(),
                SutunBasliklariniGoster = txtSutunBasliklariGoster.Text.GetEnum<EvetHayir>(),
                YaziciciAdi = txtYaziciAdi.Text,
                YazdirilacakAdet = (int)txtYazdirilacakAdet.Value,
                DokumSekli = _dokumSekli
             };
            return entity;
        }

        protected override void Yazdir()
        {
            _dokumSekli = DokumSekli.TabloYazdir;
            Close();
        }

        protected override void BaskiOnizleme()
        {
            _dokumSekli = DokumSekli.TabloBaskiOnizleme;
            Close();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtBaslikEkle) return;
            txtRaporBasligi.Enabled = txtBaslikEkle.Text.GetEnum<EvetHayir>() == EvetHayir.Evet;
        }
    }
}