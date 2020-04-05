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

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.DersForms
{
    public partial class DersListForm : BaseListForm
    {

        private readonly Expression<Func<DersEntity, bool>> _filter;
        public DersListForm()
        {
            InitializeComponent();
            Bll = new DersBll();
            _filter = x => x.durum == AktifKartlariGoster;
        }
        public DersListForm(string a, params object[] prm):this()
        {
            _filter = x => x.durum == !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.durum == AktifKartlariGoster&&x.SubeId==AnaForm.SubeId;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ders;
            FormShow = new ShowEditforms<DersEditForm>();
            base.Navigator = longNavigator.Navigator;
            
        }

        protected override void Listele()
        {
            var list = ((DersBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartKalmadiHataMesaj();
        }

    }
}