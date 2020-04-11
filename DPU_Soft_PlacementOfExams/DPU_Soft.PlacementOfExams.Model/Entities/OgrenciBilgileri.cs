using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class OgrenciBilgileri : BaseHareketEntity
    {
        public string OgrenciAdi { get; set; }
        public string OgrenciBolum { get; set; }
        public string OgrenciDers { get; set; }
        public string OgrenciNo { get; set; }
        public long? SinavSalonuId { get; set; }
        public SinavSalonuEntity SinavSalonu { get; set; }
        public long SinavKayitId { get; set; }
        public SinavKayitEntity SinavKayit { get; set; }

    }
}
