using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class OkulEntity:BaseDurumEntity
    {
        [Index("IX_Kod", IsUnique =true)]
        public override string Kod { get; set; }
        
        [Required, StringLength(50)]
        public string FakulteAdi { get; set; }
        public long UniversiteId { get; set; }
        public long IlId { get; set; }
        public long IlceId { get; set; }
        [StringLength(50)]
        public string Aciklama { get; set; }

        public IlceEntity Ilce { get; set; }

        
        public IlEntity Il { get; set; }

        public UniversiteEntity Universite { get; set; }




    }
}
