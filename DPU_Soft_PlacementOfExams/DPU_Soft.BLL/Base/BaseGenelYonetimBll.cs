using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Data.Contexts;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace DPU_Soft.BLL.Base
{
    public class BaseGenelYonetimBll<T> : BaseBll<T, PlacementOfExamsYonetimContext> where T : BaseEntity
    {
        private KartTuru _kartTuru;

        public BaseGenelYonetimBll(KartTuru kartTuru)
        {
            _kartTuru = kartTuru;
        }
        public BaseGenelYonetimBll(Control ctrl, KartTuru kartTuru) : base(ctrl)
        {
            _kartTuru = kartTuru;
        }

        public virtual BaseEntity Single(Expression<Func<T, bool>> filter)
        {
            return Basesingle(filter, x => x);
        }

        public virtual IEnumerable<BaseEntity> List(Expression<Func<T, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }

        public bool Insert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }
        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);

        }
        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);

        }





        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, _kartTuru,false);

        }

        public string YeniKodVer()
        {
            return BaseYeniKodVer(_kartTuru, x => x.Kod);
        }

        public string YeniKodVer(Expression<Func<T, bool>> filter)
        {
            return BaseYeniKodVer(_kartTuru, x => x.Kod, filter);
        }

    }
}
