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
    public class OgrenciEntity : BaseDurumEntity
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50)]
        public string OgrenciAdi { get; set; }
        [StringLength(20)]
        public string OkulNo { get; set; }
        public string Bolum { get; set; }

    }
}
