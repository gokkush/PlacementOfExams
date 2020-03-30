using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;


namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.IlceForms
{
    public partial class IlceListForm : BaseListForm
    {
        private readonly long _ilId;
        private readonly string _ilAdi;
        
        public IlceListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new IlceBll();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ilce;
            //FormShow = new ShowEditforms<IlceEditForm>();
            base.Navigator = longNavigator.Navigator;
            Text = Text + " - (" + _ilAdi + ")";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlceBll)Bll).List(x=>x.durum==AktifKartlariGoster&&x.IlId==_ilId);
        }

        protected override void ShowEditForm(long id)
        {
            var result= new ShowEditforms<IlceEditForm>().ShowDialogeditForm(KartTuru.Ilce,id,_ilId,_ilAdi);
            ShowEditFormDefault(result);

        }
    }
}