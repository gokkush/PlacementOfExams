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
    public class SinavSalonuEntity : BaseDurumEntity
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Salon Adı", "txtSalonAdi")]
        public string SalonAdi { get; set; }

        [ZorunluAlan("Salon Kapasitesi", "txtSalonKapasitesi")]
        public int SalonKapasitesi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
