using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Show;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GozetmenForms
{
    public partial class GozetmenListForm : BaseListForm
    {
        public GozetmenListForm()
        {
            InitializeComponent();
            Bll = new GozetmenBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Gozetmen;
            FormShow = new ShowEditforms<GozetmenEditForm>();
            base.Navigator = longNavigator.Navigator;

        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((GozetmenBll)Bll).List(FilterFunctions.Filter<GozetmenEntity>(AktifKartlariGoster));
        }

    }
}