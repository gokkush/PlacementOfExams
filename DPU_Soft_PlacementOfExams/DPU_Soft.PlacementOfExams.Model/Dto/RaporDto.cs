using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.Model.Dto
{
    public class RaporL:BaseEntity
    {
        public string RaporAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
