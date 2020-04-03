using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.Common.Enums
{
    public enum SinavTuru:byte
    {
        [Description("Vize Sınavı")]
        Vize=1,
        [Description("Final Sınavı")]
        Final =2,
        [Description("Bütünleme Sınavı")]
        Butunleme =3,
        [Description("Proje Sınavı")]
        Proje =4,
        [Description("Tasarım Sınavı")]
        Tasarım = 5,
        [Description("Staj Mülakatı")]
        Staj = 6,
        [Description("Diğer Sınav Türü")]
        Diger = 7

    }
}
