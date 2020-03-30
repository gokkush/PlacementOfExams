using DPU_Soft.BLL.Base;
using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using System.Windows.Forms;

namespace DPU_Soft.BLL.General
{
    public class IlceBll: BaseGenelBll<IlceEntity>,IBaseCommonBll
    {
        
        public IlceBll():base(KartTuru.Ilce)
        {

        }

        public IlceBll(Control ctrl) : base(ctrl,KartTuru.Ilce)
        {

        }
    }
}

