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
    public class DonemBll : BaseGenelBll<DonemEntity>, IBaseHareketSelectBll, IBaseCommonBll
    {
        // private KartTuru _kartTuru;
        public DonemBll() : base(KartTuru.Donem)
        {

        }
        public DonemBll(Control ctrl) : base(ctrl, KartTuru.Donem)
        {

        }
    }


}
