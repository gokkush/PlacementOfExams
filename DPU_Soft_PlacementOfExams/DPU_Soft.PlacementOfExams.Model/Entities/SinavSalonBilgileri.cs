using DPU_Soft.PlacementOfExams.Model.Entities.Base;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class SinavSalonBilgileri: BaseHareketEntity
    {
        public int SalonKapasitesi { get; set; }
        public int GozetmenSayisi { get; set; }
        public long SinavKayitId { get; set; }
        public long SinavSalonuId { get; set; }

        public SinavSalonuEntity SinavSalonu { get; set; }
        public SinavKayitEntity SinavKayit { get; set; }

    }
}
