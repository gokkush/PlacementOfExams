using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using System;
using System.Linq;

namespace DPU_Soft.BLL.Functions
{
    public static class Converts
    {
        public static TTarget EntityConvert<TTarget>(this IBaseEntity source)
        {
            if (source == null) return default(TTarget);
            var hedef = Activator.CreateInstance<TTarget>();
            var kaynakProperties = source.GetType().GetProperties();
            var hedefProperties = typeof(TTarget).GetProperties();

            foreach (var kaynakprop in kaynakProperties)
            {
                var value = kaynakprop.GetValue(source);
                var hedefprof = hedefProperties.FirstOrDefault(x => x.Name == kaynakprop.Name);
                if (hedefprof!=null)
                {
                    hedefprof.SetValue(hedef, ReferenceEquals(value, "")?null:value);
                }

            }
            return hedef;
        }
    }
}
