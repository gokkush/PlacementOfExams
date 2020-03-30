using DPU_Soft.BLL.Base;
using DPU_Soft.PlacementOfExams.Data.Contexts;
using DPU_Soft.PlacementOfExams.Model.Dto;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using DPU_Soft.PlacementOfExams.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Linq;

namespace DPU_Soft.BLL.General
{
    public class OkulBll:BaseBll<Okul,PlacementOfExamsContext>
    {
        public OkulBll()
        {

        }
        public OkulBll(Control ctrl): base(ctrl)
        {

        }

        public BaseEntity Single(Expression<Func<Okul,bool>> filter)
        {
            return Basesingle(filter, x => new OkulS
            {
                id = x.id,
                Kod = x.Kod,
                UniversiteAdi = x.UniversiteAdi,
                FakulteAdi=x.FakulteAdi,
                IlId = x.IlceId,
                IlAdi = x.Il.IlAdi,
                IlceId=x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                Aciklama=x.Aciklama,
                durum=x.durum
                
            });
        }
        
        public IEnumerable<BaseEntity> List(Expression<Func<Okul, bool>> filter)
        {
            return BaseList(filter, x => new OkulL
            {
                id = x.id,
                Kod=x.Kod,
                UniversiteAdi=x.UniversiteAdi,
                FakulteAdi=x.FakulteAdi,
                IlAdi=x.Il.IlAdi,
                IlceAdi=x.Ilce.IlceAdi,
                Aciklama=x.Aciklama
                
            }).OrderBy(x=>x.Kod).ToList();
        }
        
        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        } 

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity,currentEntity,x=>x.Kod==currentEntity.Kod);

        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Okul);

        }
    }
}
