using DevExpress.DataAccess.ObjectBinding;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPU_Soft.PlacementOfExams.Model.Dto
{
    [NotMapped]
    public class SinavKayitS:SinavKayitEntity
    {

        public string SubeAdi { get; set; }
        public string DonemAdi { get; set; }
    }
    public class SinavKayitL : BaseEntity
    {
        public string SinavAdi { get; set; }
        public string DersAdi { get; set; }
        public SinavTuru SinavTuru { get; set; }
        public string SubeAdi { get; set; }
        public string DonemAdi { get; set; }
        public bool Durum { get; set; }
    }
    [HighlightedClass]
    public class SinavKayitR:IBaseEntity
    {
        public string SinavAdi { get; set; }
        public string DersAdi { get; set; }
        public SinavTuru SinavTuru { get; set; }
        public string SubeAdi { get; set; }
        public string DonemAdi { get; set; }
        public string Adres { get; set; }
        public string AdresIlAdi { get; set; }
        public string AdresIlceAdi { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }
        public string KurumAdi { get; set; }
        public string SalonAdi { get; set; }
        public OgrenciBilgileriR OgrenciAdiSoyadi { get; set; }
        public OgrenciBilgileriR OgrenciNo { get; set; }
        public OgrenciBilgileriR OgrenciBolum { get; set; }
        public OgrenciBilgileriR OgrenciDers { get; set; }
        public OgrenciBilgileriR OgrencininSinavSalonu { get; set; }

        public SinavSalonBilgileriR SinavSalonAdi { get; set; }
        public SinavSalonBilgileriR SinavSalonKapasitesi { get; set; }
        public SinavSalonBilgileriR GozetmenSayisi { get; set; }

        
        public GozetmenBilgileriR GozetmenAdiSoyadi { get; set; }
        public GozetmenBilgileriR GozetmenGorevliOlduguSalon { get; set; }
    }
}
