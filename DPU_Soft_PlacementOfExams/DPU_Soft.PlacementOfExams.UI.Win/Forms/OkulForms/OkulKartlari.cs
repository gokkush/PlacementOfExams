using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;


namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.OkulForms
{
    public partial class OkulKartlari : BaseCardsForm
    {
        public OkulKartlari()
        {
            InitializeComponent();
            OkulBll bll = new OkulBll();
           grid.DataSource= bll.List(null);
            
        }
    }
}