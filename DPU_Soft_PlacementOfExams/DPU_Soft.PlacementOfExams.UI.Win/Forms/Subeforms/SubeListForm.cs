using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.Subeforms
{
    public partial class SubeListForm : BaseListForm
    {
        private readonly Expression<Func<SubeEntity, bool>> _filter;
        public SubeListForm()
        {
            InitializeComponent();
            Bll = new SubeBll();
            _filter = x => x.durum == AktifKartlariGoster;
            ShowItems = new DevExpress.XtraBars.BarItem[] { };
        }
        public SubeListForm(params object[] prm):this()
        {

            _filter = x => x.durum == !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Sube;
            FormShow = new ShowEditforms<SubeEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            //Tablo.GridControl.DataSource = ((SubeBll)Bll).List(FilterFunctions.Filter<SubeEntity>(AktifKartlariGoster));

            var list = ((SubeBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartSecmemeHataMesaj();
        }
    }
}