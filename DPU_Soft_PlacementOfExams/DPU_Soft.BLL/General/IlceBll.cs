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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPU_Soft.BLL.General
{
    public class IlceBll: BaseBll<IlceEntity, PlacementOfExamsContext>,IBaseCommonBll
    {
        public IlceBll()
        {

        }

        public IlceBll(Control ctrl) : base(ctrl)
        {

        }
        public BaseEntity Single(Expression<Func<IlceEntity, bool>> filter)
        {
            return Basesingle(filter, x => x);
        }

        public IEnumerable<BaseEntity> List(Expression<Func<IlceEntity, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity, Expression<Func<IlceEntity, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<IlceEntity, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);

        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Ilce);

        }

        public string YeniKodVer(Expression<Func<IlceEntity, bool>> filter)
        {
            return BaseYeniKodVer(KartTuru.Ilce, x => x.Kod,filter);
        }
    }
}

