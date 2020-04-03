using DevExpress.XtraBars;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.SinavKayitForms
{
    public partial class SinavKayitListForm : BaseListForm
    {
        private readonly Expression<Func<SinavKayitEntity, bool>> _filter;
        public SinavKayitListForm()
        {
            InitializeComponent();
            Bll = new SinavKayitBll();
            HideItems = new BarItem[] { };
            _filter = x => x.durum == AktifKartlariGoster&&x.DonemId==AnaForm.DonemId&&x.SubeId==AnaForm.SubeId;


        }
        public SinavKayitListForm(params object[] prm):this()
        {
            _filter = x => x.durum == !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.durum == AktifKartlariGoster && x.DonemId==AnaForm.DonemId&&x.SubeId == AnaForm.DonemId;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.SinavKayit;
            FormShow = new ShowEditforms<SinavKayitEditForm>();
            base.Navigator = longNavigator.Navigator;

        }

        protected override void Listele()
        {
            var list = ((SinavKayitBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartSecmemeHataMesaj();
        }

    }
}