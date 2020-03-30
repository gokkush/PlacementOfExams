using System;
using System.ComponentModel;

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
    }
}
