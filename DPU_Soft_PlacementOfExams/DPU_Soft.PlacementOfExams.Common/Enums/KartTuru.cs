using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.Common.Enums
{
    public enum KartTuru:byte
    {
        [Description("Fakulte Kaydı")]
        Okul=1,
        [Description("Il Kaydı")]
        Il =2,
        [Description("Ilce Kaydı")]
        Ilce =3,
        [Description("Unv Kaydı")]
        Universite = 4,
        [Description("Filtre Kaydı")]
        Filtre = 5,
        [Description("Kullanici Kaydı")]
        Kullanici = 6,
        [Description("Kurum Kaydı")]
        Kurum = 7,
        [Description("Sube Kaydı")]
        Sube = 8,
        [Description("Donem Kaydı")]
        Donem = 9


    }
}
