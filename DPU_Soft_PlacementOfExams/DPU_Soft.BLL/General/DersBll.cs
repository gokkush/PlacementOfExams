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
    public class DersBll : BaseGenelBll<DersEntity>, IBaseHareketSelectBll, IBaseCommonBll
    {
        public DersBll() : base(KartTuru.Ders)
        {

        }

        public DersBll(Control ctrl) : base(ctrl, KartTuru.Ders)
        {

        }
    }
}
