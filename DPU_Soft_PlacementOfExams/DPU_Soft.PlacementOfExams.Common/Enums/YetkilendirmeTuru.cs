using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.Common.Enums
{
    public enum YetkilendirmeTuru:byte
    {
        [Description("Sql Server Yetkilendirilmesi")]
        SqlServer = 1,
        [Description("Windows Yetkilendirilmesi")]
        Windows = 2,
        
    }
}
