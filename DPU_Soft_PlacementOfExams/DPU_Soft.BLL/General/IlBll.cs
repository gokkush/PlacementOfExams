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
<<<<<<< HEAD
    public class IlBll:BaseBll<IlEntity, PlacementOfExamsContext>, IBaseGenelBll
=======
    public class IlBll:BaseBll<IlEntity, PlacementOfExamsContext>, IBaseGenelBll,IBaseCommonBll
>>>>>>> yandal
    {
        public IlBll()
        {

        }
        public IlBll(Control ctrl) : base(ctrl)
        {

        }
        public BaseEntity Single(Expression<Func<IlEntity, bool>> filter)
        {
<<<<<<< HEAD
            return Basesingle(filter, x => new IlEntity
            {
                id = x.id,
                Kod = x.Kod,
                IlAdi = x.IlAdi,
                Aciklama = x.Aciklama,
                durum = x.durum

            });
=======
            return Basesingle(filter, x => x);
>>>>>>> yandal
        }

        public IEnumerable<BaseEntity> List(Expression<Func<IlEntity, bool>> filter)
        {
<<<<<<< HEAD
            return BaseList(filter, x => new IlEntity
            {
                id = x.id,
                Kod = x.Kod,
                IlAdi = x.IlAdi,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
=======
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
>>>>>>> yandal
        }

        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);

        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Il);

        }

        public string YeniKodVer()
        {
            return BaseYeniKodVer(KartTuru.Il, x => x.Kod);
        }
    }

}
