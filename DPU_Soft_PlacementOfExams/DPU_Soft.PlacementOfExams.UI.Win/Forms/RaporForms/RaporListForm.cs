using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Show;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.RaporForms
{
    public partial class RaporListForm : BaseListForm
    {
        private readonly KartTuru _raporTuru;
        private readonly RaporBolumTuru _raporBolumTuru;
        private readonly byte[] _dosya;
        public RaporListForm(params object[]prm)
        {
            InitializeComponent();
            Bll = new RaporBll();

            _raporTuru = (KartTuru)prm[0];
            _raporBolumTuru = (RaporBolumTuru)prm[1];
            _dosya = (byte[])prm[2];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.RaporTuru;
            FormShow = new ShowEditforms<RaporEditForm>();
            base.Navigator = longNavigator.Navigator;

        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((RaporBll)Bll).List(FilterFunctions.Filter<RaporEntity>(AktifKartlariGoster));
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditforms<RaporEditForm>.ShowDialogeditForm(KartTuru.RaporTuru, id,_raporTuru,_raporBolumTuru,_dosya);
            ShowEditFormDefault(result);
        }


    }
}