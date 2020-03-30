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
    public class KullaniciS:KullaniciEntity
    {
        public string FakulteAdi { get; set; }
    }

    public class KullaniciL:BaseEntity
    {
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Email { get; set; }

        public string FakulteAdi { get; set; }
        public string Aciklama { get; set; }
    }


}
