using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class KullaniciBirimYetkileriEntity:BaseHareketEntity
    {
        public long KullaniciId  { get; set; }
        public KartTuru KartTuru { get; set; }

        public long?  SubeId { get; set; }
        public long? DonemId { get; set; }

        public KullaniciEntity Kullanici { get; set; }

        public SubeEntity Sube { get; set; }

        public DonemEntity Donem { get; set; }

    }
}
