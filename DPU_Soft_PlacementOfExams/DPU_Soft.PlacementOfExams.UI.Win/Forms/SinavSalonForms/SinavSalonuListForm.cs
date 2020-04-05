using System;
using System.Linq;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Common.Massage;
using System.Linq.Expressions;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.SinavSalonForms
{
    public partial class SinavSalonuListForm : BaseListForm
    {
        private readonly Expression<Func<SinavSalonuEntity, bool>> _filter;
        public SinavSalonuListForm()
        {
            InitializeComponent();
            Bll = new SinavSalonuBll();
            _filter = x => x.durum == AktifKartlariGoster;
        }

        public SinavSalonuListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id)&&AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Salon;
            FormShow = new ShowEditforms<SinavSalonuEditForm>();
            base.Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((SinavSalonuBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartKalmadiHataMesaj();
            Tablo.GridControl.DataSource = ((SinavSalonuBll)Bll).List(FilterFunctions.Filter<SinavSalonuEntity>(AktifKartlariGoster));

        }


    }
}