using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.DersForms
{
    public partial class DersYetkiEditForm : BaseEditForm
    {
        public DersYetkiEditForm()
        {
            InitializeComponent();
            EventsLoad();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnYeni, btnKaydet, btnSil, btnGeriAl };
            TabloYukle();
        }
        public override void Yukle()
        {

         dersTable.Yukle();
        }

        protected internal override void ButtonEnabledDurumu()
        {

        }

        protected override void TabloYukle()
        {
            dersTable.OvnerForm = this;
            dersTable.Yukle();
        }
    }
}