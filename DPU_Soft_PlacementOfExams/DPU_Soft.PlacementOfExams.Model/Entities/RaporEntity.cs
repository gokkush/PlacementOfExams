using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Attributes;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class RaporEntity:BaseDurumEntity
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Rapor Adı", "txtRaporAdi")]
        public string RaporAdi { get; set; }
        public KartTuru RaporTuru { get; set; }
        public RaporBolumTuru RaporBolumTuru { get; set; }
        [Required]
        public byte[] Dosya { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
