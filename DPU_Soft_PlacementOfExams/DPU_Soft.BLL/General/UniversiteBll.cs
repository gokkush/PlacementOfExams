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
    public class UniversiteBll : BaseBll<UniversiteEntity, PlacementOfExamsContext>, IBaseGenelBll
    {
        public UniversiteBll()
        {

        }
        public UniversiteBll(Control ctrl) : base(ctrl)
        {

        }

        public BaseEntity Single(Expression<Func<UniversiteEntity, bool>> filter)
        {
            return Basesingle(filter, x => new UniversiteEntity
            {
                id = x.id,
                Kod = x.Kod,
                UniversiteAdi = x.UniversiteAdi,
                Aciklama = x.Aciklama,
                durum = x.durum

            });
        }

        public IEnumerable<BaseEntity> List(Expression<Func<UniversiteEntity, bool>> filter)
        {
            return BaseList(filter, x => new UniversiteEntity
            {
                id = x.id,
                Kod = x.Kod,
                UniversiteAdi = x.UniversiteAdi,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
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
            return BaseDelete(entity, KartTuru.Universite);

        }

        public string YeniKodVer()
        {
            return BaseYeniKodVer(KartTuru.Universite, x => x.Kod);
        }
    }
}

