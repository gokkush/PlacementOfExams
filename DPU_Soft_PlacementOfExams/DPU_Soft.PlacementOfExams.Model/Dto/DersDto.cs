using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.Model.Dto
{
    [NotMapped]
    public class DersL : DersEntity
    {
        public string SubeAdi { get; set; }
        public string DonemAdi { get; set; }

    }
}
