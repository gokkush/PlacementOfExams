using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.Common.Enums
{
    public enum DokumSekli:byte
    {
        [Description("Tablo Baskı Önizleme")]
        TabloBaskiOnizleme = 1,
        [Description("Rapor Baskı Önizleme")]
        RaporBaskiOnizleme = 2,
        [Description("Tablo Yazdır")]
        TabloYazdir = 3,
        [Description("Rapor Yazdır")]
        RaporYazdir = 4,


    }
}
