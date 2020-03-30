using DPU_Soft.PlacementOfExams.Model.Entities.Base;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class IlceEntity:BaseEntityDurum
    {
        public string IlceAdi { get; set; }

        public string Aciklama { get; set; }

        public long IlId { get; set; }
        public IlEntity Il { get; set; }
    }
}
