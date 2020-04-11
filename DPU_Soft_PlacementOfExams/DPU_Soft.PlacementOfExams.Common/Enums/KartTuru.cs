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
        Donem = 9,
        [Description("Salon Kaydı")]
        Salon = 10,
        [Description("Gozetmen Kaydı")]
        Gozetmen = 11,
        [Description("Ders Kaydı")]
        Ders = 12,
        [Description("Ogrenci Kaydı")]
        Ogrenci = 13,
        [Description("Sınav Kaydı")]
        SinavKayit = 14,
        [Description("Salon-Bilgi Kaydı")]
        SinavSalonBilgiKayit = 15,
        [Description("Gozetmen-Bilgi Kaydı")]
        GozetmenBilgiKayit = 16,
        [Description("Rapor Kaydı")]
        RaporTuru = 17,
        [Description("Rapor-Tasarım Kaydı")]
        RaporTasarim = 18,
        [Description("Salon-Listesi Raporu")]
        SalonListesiRaporu = 19,
        [Description("Yoklama-Listesi Raporu")]
        YoklamaListesiRaporu = 20,
        [Description("Sinav-Listesi Raporu")]
        SinavListesiRaporu = 21,
        [Description("Boş Rapor")]
        BosRapor = 22



    }
}
