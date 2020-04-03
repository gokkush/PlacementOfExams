using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Attributes;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class SinavKayitEntity:BaseDurumEntity
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        public string SinavAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public long DersId { get; set; }
        public SinavTuru SinavTuru { get; set; } = SinavTuru.Vize;
        public long SubeId { get; set; }
        public long DonemId  { get; set; }

        public SubeEntity Sube { get; set; }
        public DonemEntity Donem { get; set; }
        public DersEntity Ders { get; set; }


    }
}
