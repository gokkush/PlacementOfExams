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
    public class GozetmenBilgileriBll : BaseHareketBll<GozetmenBilgileri, PlacementOfExamsContext>, IBaseHareketSelectBll<GozetmenBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<GozetmenBilgileri, bool>> filter)
        {
            return List(filter, x => new GozetmenBilgileriL
            {
                id = x.id,
                GozetmenAdi = x.GozetmenAdi,
                GozetmenId = x.GozetmenId,
                GorevlendirmeSayisi = x.GorevlendirmeSayisi,
                SinavKayitId = x.SinavKayitId,
                durum = x.durum
            }).ToList();
        }
    }
}
