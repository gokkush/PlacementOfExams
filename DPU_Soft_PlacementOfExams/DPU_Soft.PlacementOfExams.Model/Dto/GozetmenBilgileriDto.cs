using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.Model.Dto
{
    [NotMapped]

    public class GozetmenBilgileriL:GozetmenBilgileri, IBaseHareketEntity
    {
        public string SinavSalonAdi { get; set; }
        public string GozetmenAdi { get; set; }
        public int GorevlendirmeSayisi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
