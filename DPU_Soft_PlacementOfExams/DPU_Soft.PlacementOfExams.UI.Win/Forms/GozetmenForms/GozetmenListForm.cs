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

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GozetmenForms
{
    public partial class GozetmenListForm : BaseListForm
    {

        private readonly Expression<Func<GozetmenEntity, bool>> _filter;
        public GozetmenListForm()
        {
            InitializeComponent();
            Bll = new GozetmenBll();
            _filter = x => x.durum == AktifKartlariGoster&&x.Sube_Id==AnaForm.SubeId;

        }
        public GozetmenListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && AktifKartlariGoster &&x.Sube_Id==AnaForm.SubeId;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Gozetmen;
            FormShow = new ShowEditforms<GozetmenEditForm>();
            base.Navigator = longNavigator.Navigator;
            Text = Text + " - (" + AnaForm.SubeAdi + ")";

        }

        protected override void Listele()
        {
            var list = ((GozetmenBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;
            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartKalmadiHataMesaj();

           // Tablo.GridControl.DataSource = ((GozetmenBll)Bll).List(x => x.durum == AktifKartlariGoster && x.Sube_Id == _subeId);
        }

        protected override void ShowEditForm(long id)
        {
            //var entity = Tablo.GetRow<GozetmenEntity>();
            //if (entity != null)
            //    return;
                var result = ShowEditforms<GozetmenEditForm>.ShowDialogeditForm(KartTuru.Gozetmen, id, AnaForm.SubeId, AnaForm.SubeAdi);
                ShowEditFormDefault(result);

        }
    }
}