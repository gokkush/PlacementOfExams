using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class GozetmenBilgileri : BaseHareketEntity
    {

        public long GozetmenId { get; set; }
        public long? SinavSalonId { get; set; }
        public long SinavKayitId { get; set; }
        public GozetmenEntity Gozetmen { get; set; }
        public SinavKayitEntity SinavKayit { get; set; }
        public SinavSalonuEntity SinavSalon { get; set; }

    }
}
