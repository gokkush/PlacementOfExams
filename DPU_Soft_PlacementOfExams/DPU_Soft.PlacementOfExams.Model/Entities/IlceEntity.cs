using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class IlceEntity:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required,StringLength(50)]
        public string IlceAdi { get; set; }

        public long IlId { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }

        
        public IlEntity Il { get; set; }
    }
}
