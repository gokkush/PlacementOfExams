using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Show;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.DersForms
{
    public partial class DersYetkiListForm : BaseListForm
    {
        public DersYetkiListForm()
        {
            InitializeComponent();
            Bll = new DersYetkiBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.DersYetki;
            FormShow = new ShowEditforms<DersYetkiEditForm>();
            base.Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((DersBll)Bll).List(FilterFunctions.Filter<DersEntity>(AktifKartlariGoster));
        }

    }
}