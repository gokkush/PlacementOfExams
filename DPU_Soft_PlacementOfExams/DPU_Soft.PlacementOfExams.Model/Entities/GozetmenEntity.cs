using DPU_Soft.PlacementOfExams.Model.Attributes;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class GozetmenEntity : BaseDurumEntity
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Gözetmen Adı", "txtGozetmenAdi")]
        public string GozetmenAdi { get; set; }
        public int GorevlendirmeSayisi { get; set; }
        public long Sube_Id { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public SubeEntity Sube { get; set; }
    }
}
