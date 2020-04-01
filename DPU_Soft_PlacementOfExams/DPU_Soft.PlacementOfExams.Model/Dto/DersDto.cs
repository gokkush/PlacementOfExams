using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.Model.Dto
{
    public class DersL : BaseEntity
    {
        public string DersAdi { get; set; }


        public string Aciklama { get; set; }
    }
}
