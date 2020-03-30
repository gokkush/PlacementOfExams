using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DevExpress.XtraGrid;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.BLL.General;
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.FiltreForms
{
    public partial class FiltreEditForm : BaseEditForm
    {
        private readonly GridControl _filtreGrid;
        private readonly KartTuru _filtreKartTuru;
        public FiltreEditForm(params object[] prm)
        {
            InitializeComponent();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            HideItems = new BarItem[] { btnYeni, btnGeriAl };
            ShowItems = new BarItem[] { btnFarkliKaydet, btnUygula };

            DataLayoutControl = dpuDataLayoutControl;
            Bll = new FiltreBll(dpuDataLayoutControl);
            BaseKartTuru = KartTuru.Filtre;
            EventsLoad();

            
        }

        protected internal override void Yukle()
        {
            txtFiltreMetni.SourceControl = _filtreGrid;

            while (true)
            {
                if (BaseIslemTuru == IslemTuru.EntityInsert)
                {
                    OldEntity = new FiltreEntity();
                    Id = BaseIslemTuru.IdOlustur(OldEntity);
                    txtKod.Text = ((FiltreBll)Bll).YeniKodVer(x => x.KartTuru == _filtreKartTuru);
                    txtFiltreAdi.Focus();
                }
                else
                {
                    OldEntity = ((FiltreBll)Bll).Single(FilterFunctions.Filter<FiltreEntity>(Id));
                    if (OldEntity == null)
                    {
                        BaseIslemTuru = IslemTuru.EntityInsert;
                        continue;
                    }

                    NesneyiKontrollereBagla();
                }
                break;
            }
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (FiltreEntity)OldEntity;

            txtKod.Text = entity.Kod;
            txtFiltreAdi.Text = entity.FiltreAdi;
            txtFiltreMetni.FilterString = entity.FiltreMetni;
            
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new FiltreEntity
            {
                Id = Id,
                Kod = txtKod.Text,
                FiltreAdi = txtFiltreAdi.Text,
                FiltreMetni = txtFiltreMetni.FilterString,
                KartTuru = _filtreKartTuru

            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((FiltreBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filtreKartTuru);
        }

        protected override bool EntityUpdate()
        {
            return ((FiltreBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filtreKartTuru);
        }

        protected override void FiltreUygula()
        {
            txtFiltreMetni.Select();
            txtFiltreMetni.ApplyFilter();
        }
        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnFarkliKaydet, btnSil, BaseIslemTuru, OldEntity, CurrentEntity);
        }
    }
}