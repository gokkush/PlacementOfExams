using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.BLL.Base.Interfaces
{
    public interface IBaseHareketSelectBll
    {
        bool Insert(BaseEntity entity);


        bool Update(BaseEntity oldEntity, BaseEntity currentEntity);

        string YeniKodVer();
        
    }
}
