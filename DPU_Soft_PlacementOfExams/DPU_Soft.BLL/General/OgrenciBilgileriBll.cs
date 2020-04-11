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

namespace DPU_Soft.BLL.General
{
    public class OgrenciBilgileriBll : BaseHareketBll<OgrenciBilgileri, PlacementOfExamsContext>, IBaseHareketSelectBll<OgrenciBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<OgrenciBilgileri, bool>> filter)
        {
            return List(filter, x => new OgrenciBilgileriL
            {
                id = x.id,
                OgrenciAdi = x.OgrenciAdi,
                OgrenciNo = x.OgrenciNo,
                OgrenciBolum = x.OgrenciBolum,
                OgrenciDers=x.OgrenciDers,
                SinavSalonuId = x.SinavSalonuId,
                SinavKayitId = x.SinavKayitId,
                SalonAdi=x.SinavSalonu.SalonAdi,
                durum = x.durum
            }).ToList();
        }
    }
}
