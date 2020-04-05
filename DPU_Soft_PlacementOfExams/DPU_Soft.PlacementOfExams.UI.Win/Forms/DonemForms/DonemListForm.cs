using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.IlForms;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.DonemForms
{
    public partial class DonemListForm : BaseListForm
    {
        private readonly Expression<Func<DonemEntity, bool>> _filter;
        public DonemListForm()
        {
            InitializeComponent();
            Bll = new DonemBll();
            _filter = x => x.durum == AktifKartlariGoster;
            ShowItems = new DevExpress.XtraBars.BarItem[] { };

        }

        public DonemListForm(params object[] prm) :this()
        {
            _filter = x => x.durum == !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Donem;
            FormShow = new ShowEditforms<DonemEditForm>();
            Navigator = longNavigator.Navigator;

        }

        protected override void Listele()
        {
            var list = ((DonemBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartKalmadiHataMesaj();
            //Tablo.GridControl.DataSource = ((DonemBll)Bll).List(FilterFunctions.Filter<DonemEntity>(AktifKartlariGoster));
        }


    }
}