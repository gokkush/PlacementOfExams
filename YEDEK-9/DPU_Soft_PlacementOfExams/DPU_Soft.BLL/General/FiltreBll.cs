using DPU_Soft.BLL.Base;
using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Data.Contexts;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace DPU_Soft.BLL.General
{
    public class FiltreBll : BaseBll<FiltreEntity, PlacementOfExamsContext>, IBaseCommonBll
    {
        public FiltreBll()
        {

        }

        public FiltreBll(Control ctrl):base(ctrl)
        {

        }

        public BaseEntity Single(Expression<Func<FiltreEntity, bool>> filter)
        {
            return Basesingle(filter, x => x);
        }

        public IEnumerable<BaseEntity> List(Expression<Func<FiltreEntity, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity, Expression<Func<FiltreEntity, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<FiltreEntity, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);

        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Filtre);

        }

        public string YeniKodVer(Expression<Func<FiltreEntity, bool>> filter)
        {
            return BaseYeniKodVer(KartTuru.Filtre, x => x.Kod, filter);
        }

    }
}
