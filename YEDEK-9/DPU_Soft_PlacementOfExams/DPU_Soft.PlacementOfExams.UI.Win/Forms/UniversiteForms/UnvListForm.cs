using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;


namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UniversiteForms
{
    public partial class UnvListForm : BaseListForm
    {
        public UnvListForm()
        {
            InitializeComponent();
            Bll = new UniversiteBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ilce;
            FormShow = new ShowEditforms<UnvEditForm>();
            base.Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((UniversiteBll)Bll).List(FilterFunctions.Filter<UniversiteEntity>(AktifKartlariGoster));
        }

    }
}