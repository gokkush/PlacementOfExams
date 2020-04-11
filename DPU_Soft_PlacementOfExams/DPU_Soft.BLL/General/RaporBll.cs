using DPU_Soft.BLL.Base;
using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPU_Soft.BLL.General
{
    public class RaporBll : BaseGenelBll<RaporEntity>, IBaseHareketSelectBll, IBaseCommonBll
    {
        public RaporBll() : base(KartTuru.RaporTuru)
        {

        }
        public RaporBll(Control ctrl) : base(ctrl, KartTuru.RaporTuru)
        {

        }


        public override IEnumerable<BaseEntity> List(Expression<Func<RaporEntity, bool>> filter)
        {
            return BaseList(filter, x => new RaporL
            {
                Id = x.Id,
                Kod = x.Kod,
                RaporAdi=x.RaporAdi,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
        }

    }
}
