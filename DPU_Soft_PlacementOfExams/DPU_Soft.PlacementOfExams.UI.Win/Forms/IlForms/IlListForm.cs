using DPU_Soft.BLL.General;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.BaseForms;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.UI.Win.Show;
using DPU_Soft.PlacementOfExams.UI.Win.Functions;
using DPU_Soft.PlacementOfExams.Model.Entities;
<<<<<<< HEAD
namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.IlForms
=======
using DevExpress.XtraBars;
using DPU_Soft.PlacementOfExams.UI.Win.Forms.IlceForms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.IlForms

>>>>>>> yandal
{
    public partial class IlListForm : BaseListForm
    {
        public IlListForm()
        {
            InitializeComponent();
            Bll = new IlBll();
<<<<<<< HEAD
=======
            btnBagliKartlar.Caption = "İlçe Kartları";
>>>>>>> yandal
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Il;
            FormShow = new ShowEditforms<IlEditForm>();
            base.Navigator = longNavigator.Navigator;
<<<<<<< HEAD
        }
=======
            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };
            
        }

>>>>>>> yandal
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlBll)Bll).List(FilterFunctions.Filter<IlEntity>(AktifKartlariGoster));
        }
<<<<<<< HEAD
=======
        protected override void BaglikartAc()
        {
            //Yetki Kontrolü

            var entity = Tablo.GetRow<IlEntity>();
            if (entity == null) return;
            ShowListforms<IlceListForm>.ShowListForm(KartTuru.Ilce,entity.Id,entity.IlAdi);
        }
>>>>>>> yandal
    }
}