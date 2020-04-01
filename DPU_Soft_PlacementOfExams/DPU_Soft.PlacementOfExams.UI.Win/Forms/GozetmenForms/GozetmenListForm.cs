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
        private readonly long _subeId;
        private readonly string _subeAdi;
        public GozetmenListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new GozetmenBll();

            _subeId = (long)prm[0];
            _subeAdi = prm[1].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Gozetmen;
           // FormShow = new ShowEditforms<GozetmenEditForm>();
            base.Navigator = longNavigator.Navigator;
            Text = Text + " - (" + _subeAdi + ")";

        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((GozetmenBll)Bll).List(x => x.durum == AktifKartlariGoster && x.GozetmenSubeId == _subeId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditforms<GozetmenEditForm>.ShowDialogeditForm(KartTuru.Gozetmen, id, _subeId, _subeAdi);
            ShowEditFormDefault(result);

        }
    }
}