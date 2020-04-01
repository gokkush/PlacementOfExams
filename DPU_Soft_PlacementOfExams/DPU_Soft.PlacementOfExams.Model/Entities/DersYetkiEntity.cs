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
    public class DersYetkiEntity : BaseHareketEntity
    {
        public long? DersId { get; set; }

        public long?  DonemId { get; set; }

        public long? SubeId { get; set; }

        public DersEntity Ders { get; set; }

    }
}
