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
    public class KullaniciEntity : BaseDurumEntity
    {
        [Index("IX_Kod", IsUnique = true), Kod("Kullanıcı Adı", ""), ZorunluAlan("Kullanıcı Adı", "")]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Adı", "txtAdi")]
        public string Adi { get; set; }

        [Required, StringLength(50), ZorunluAlan("Soyadı", "txtSoyadi")]
        public string Soyadi { get; set; }

        [Required, StringLength(50), ZorunluAlan("E-Mail", "txtEMail")]
        public string Email { get; set; }

        [Required, StringLength(50)]
        public string Sifre { get; set; }

        [Required, StringLength(50)]
        public string GizliKelime { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
