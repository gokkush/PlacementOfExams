using DPU_Soft.BLL.Base;
using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Enums;
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
    public class SinavSalonBilgileriBll : BaseHareketBll<SinavSalonBilgileri, PlacementOfExamsContext>, IBaseHareketSelectBll<SinavSalonBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<SinavSalonBilgileri, bool>> filter)
        {
            return List(filter, x => new SinavSalonBilgileriL
            {
                id=x.id,
                SalonAdi=x.SinavSalonu.SalonAdi,
                SalonKapasitesi=x.SalonKapasitesi,
                GozetmenSayisi=x.GozetmenSayisi,
                SinavKayitId=x.SinavKayitId,
                SinavSalonuId=x.SinavSalonuId, 
            }).ToList();
        }
    }
}
