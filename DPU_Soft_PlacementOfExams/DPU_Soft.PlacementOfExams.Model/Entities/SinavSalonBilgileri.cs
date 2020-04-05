using DPU_Soft.PlacementOfExams.Model.Entities.Base;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class SinavSalonBilgileri: BaseHareketEntity
    {
        public string SalonAdi { get; set; }
        public int SalonKapasitesi { get; set; }
        public int GozetmenSayisi { get; set; }
        public long SinavKayitId { get; set; }
        public long SinavSalonu_Id { get; set; }
        public SinavKayitEntity SinavKayit { get; set; }

    }
}
