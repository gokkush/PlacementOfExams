using DPU_Soft.BLL.Base;
using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPU_Soft.BLL.General
{
    public class GozetmenBll : BaseGenelBll<GozetmenEntity>, IBaseHareketSelectBll, IBaseCommonBll
    {
        public GozetmenBll() : base(KartTuru.Gozetmen)
        {

        }

        public GozetmenBll(Control ctrl) : base(ctrl, KartTuru.Gozetmen)
        {

        }
    }
}
