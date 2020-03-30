using DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Base;
using DPU_Soft.BLL.General;
using DevExpress.XtraGrid.Views.Base;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.KullaniciForms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.KullaniciBirimYetkileriFormTable
{
    public partial class KullaniciTable : BaseTablo
    {
        public KullaniciTable()
        {
            InitializeComponent();

            Bll = new KullaniciBll();
            Tablo = tablo;

            EventsLoad();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnHareketEkle, btnHareketSil };
            ınsUptNavigator.Navigator.Buttons.Append.Visible = false;
            ınsUptNavigator.Navigator.Buttons.Remove.Visible = false;
            ınsUptNavigator.Navigator.Buttons.PrevPage.Visible = true;
            ınsUptNavigator.Navigator.Buttons.NextPage.Visible = true;

        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((KullaniciBll)Bll).List(null);
        }
        protected override void HareketSil()
        {
            
        }

        protected override void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            var entity = tablo.GetRow<KullaniciL>();
            if (entity == null) return;

            OvnerForm.Id = entity.Id;
            ((KullanicibirimYetkileriEditForm)OvnerForm).Yukle();
        }
    }
}
