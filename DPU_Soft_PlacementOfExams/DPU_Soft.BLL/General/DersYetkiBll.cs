using DPU_Soft.BLL.Base;
using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.PlacementOfExams.Data.Contexts;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.BLL.General
{
    public class DersYetkiBll : BaseHareketBll<DersYetkiEntity, PlacementOfExamsContext>, IBaseHareketSelectBll<DersYetkiEntity>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<DersYetkiEntity, bool>> filter)
        {
            return List(filter, x => new DersYetkiL
            {
                id = x.id,
                Kod=x.Ders.Kod,
                SubeId = x.SubeId,
                DersAdi=x.Ders.DersAdi,
                DonemId = x.DonemId,
                DersId=x.DersId
                

            }).ToList();

        }
    }
}
