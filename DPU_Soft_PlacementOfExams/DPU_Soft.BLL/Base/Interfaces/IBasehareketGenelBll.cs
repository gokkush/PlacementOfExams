using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System.Collections.Generic;

namespace DPU_Soft.BLL.Base.Interfaces
{
    public interface IBasehareketGenelBll
    {
        bool Insert(IList<BaseHareketEntity> entities);
        bool Update(IList<BaseHareketEntity> entities);
        bool Delete(IList<BaseHareketEntity> entities);
    }
}
