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
    public class SubeEntity:BaseDurumEntity
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Şube Adı", "txtSubeAdi")]
        public string SubeAdi { get; set; }

        [StringLength(255)]
        public string Adres { get; set; }

        [ZorunluAlan("İl Adı", "txtAdresIl")]
        public long AdresIlId { get; set; }

        [ZorunluAlan("İlçe Adı", "txtAdresIlce")]
        public long AdresIlceId { get; set; }

        [StringLength(17)]
        public string Telefon { get; set; }
        [StringLength(17)]
        public string Faks { get; set; }

        public IlEntity AdresIl { get; set; }

        public IlceEntity AdresIlce { get; set; }


    }
}
