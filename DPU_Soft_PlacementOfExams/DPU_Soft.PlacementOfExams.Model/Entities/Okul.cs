using DPU_Soft.PlacementOfExams.Model.Entities.Base;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class Okul:BaseEntityDurum
    {
        public string UniversiteAdi { get; set; }
        public long IlId { get; set; }
        public long IlceId { get; set; }
        public string Aciklama { get; set; }

        public IlceEntity Ilce { get; set; }

        
        public IlEntity Il { get; set; }




    }
}
