using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.Common.Enums
{
    public enum YazdirmaSekli:byte
    {
        [Description("Tek Tek Yazdır")]
        TekTekYazdir=1,
        [Description("Tümünü Yazdır")]
        TopluYazdir =2
    }
}
