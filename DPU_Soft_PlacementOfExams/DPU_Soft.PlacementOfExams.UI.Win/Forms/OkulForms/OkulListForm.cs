using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.OkulForms
{
    public partial class OkulListForm : BaseListForm
    {
        public OkulListForm()
        {
            InitializeComponent();
            Bll = new OkulBll();

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Okul;
            FormShow = new ShowEditforms<OkulEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OkulBll)Bll).List(FilterFunctions.Filter<OkulEntity>(AktifKartlariGoster));
        }


    }
}