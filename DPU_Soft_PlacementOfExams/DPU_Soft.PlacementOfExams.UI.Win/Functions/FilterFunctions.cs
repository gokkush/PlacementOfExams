using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.UI.Win.Functions
{
    public class FilterFunctions
    {
        public static Expression<Func<T,bool>>Filter<T>(bool aktifKartlariGoster) where T:BaseDurumEntity
        {
            return x => x.durum == aktifKartlariGoster;
        }
        public static Expression<Func<T,bool>> Filter<T>(long id) where T:BaseDurumEntity
        {
            return x => x.Id == id;
        }
    }
}
