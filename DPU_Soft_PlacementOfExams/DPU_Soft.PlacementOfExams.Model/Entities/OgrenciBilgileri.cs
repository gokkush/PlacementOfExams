using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class OgrenciBilgileri : BaseHareketEntity
    {
        [StringLength(50)]
        public string OgrenciAdi { get; set; }

        [StringLength(70)]
        public string OgrenciBolum { get; set; }

        [StringLength(50)]
        public string OgrenciDers { get; set; }

        [StringLength(15)]
        public string OgrenciNo { get; set; }
        public int SiraNo { get; set; }
        public long? SinavSalonuId { get; set; }
        public SinavSalonuEntity SinavSalonu { get; set; }
        public long SinavKayitId { get; set; }
        public SinavKayitEntity SinavKayit { get; set; }

    }
}
