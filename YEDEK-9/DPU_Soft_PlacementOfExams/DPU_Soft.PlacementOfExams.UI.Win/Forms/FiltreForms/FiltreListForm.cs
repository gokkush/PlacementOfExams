using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.FiltreForms
{
    public partial class FiltreListForm : BaseListForm
    {
        private readonly GridControl _filtreGrid;
        private readonly KartTuru _filtreKartTuru;
        public FiltreListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new FiltreBll();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];
            HideItems = new BarItem[] { btnFiltrele, btnKolonlar, btnYazdir, btnGonder, barFiltrele, barFiltrelemeAciklama, barKolonlar, barKolonlarAciklama, barGonder, barGonderAciklama, barYazdir, barYazdirAciklama };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Filtre;
            //FormShow = new ShowEditforms<IlceEditForm>();
            base.Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((FiltreBll)Bll).List(x=>x.KartTuru==_filtreKartTuru);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditforms<FiltreEditForm>.ShowDialogeditForm(KartTuru.Filtre, id, _filtreKartTuru, _filtreGrid);
            ShowEditFormDefault(result);

        }

    }
}