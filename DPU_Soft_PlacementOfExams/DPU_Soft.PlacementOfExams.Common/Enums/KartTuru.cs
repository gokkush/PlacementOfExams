using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.Common.Enums
{
    public enum KartTuru:byte
    {
        [Description("Okul Kaydı")]
        Okul=1,
        [Description("İl Kaydı")]
        Il =2,
        [Description("İlçe Kaydı")]
        Ilce =3
    }
}
