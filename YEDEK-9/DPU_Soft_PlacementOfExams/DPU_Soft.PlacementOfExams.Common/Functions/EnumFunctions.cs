using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;

namespace DPU_Soft.PlacementOfExams.Common.Functions
{
    public static class EnumFunctions
    {
        private static T GetAttribute<T>(this Enum value) where T:Attribute
        {
            if (value == null) return null;
            var numberInfo = value.GetType().GetMember(value.ToString());
            var attributes = numberInfo[0].GetCustomAttributes(typeof(T), false);
            return (T)attributes[0];
        }

        public static string ToName(this Enum value)
        {
            if (value == null) return null;
            var attribure = value.GetAttribute<DescriptionAttribute>();
            return attribure == null ? value.ToString() : attribure.Description;
        }

        public static ICollection GetEnumDescriptionList<T>()
        {
            return typeof(T).GetMembers().
                SelectMany(x=>x.GetCustomAttributes(typeof(DescriptionAttribute),true).
                Cast<DescriptionAttribute>()).
                Select(x=>x.Description).ToList();
        }

        public static T GetEnum<T>(this string description)
        {
            var enumName = Enum.GetNames(typeof(T));
            foreach (var enm in enumName.Select(x => Enum.Parse(typeof(T), x)).Where(y => description == ToName((Enum)y)))
            {
                return (T)enm;

            }

            return default(T);
        }
    }
}
