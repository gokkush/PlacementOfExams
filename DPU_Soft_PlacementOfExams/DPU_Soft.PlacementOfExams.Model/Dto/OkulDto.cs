using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPU_Soft.PlacementOfExams.Model.Dto
{
    [NotMapped]
    public class OkulS:OkulEntity
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string UniversiteAdi { get; set; }
    }

    public class OkulL :BaseEntity
    {
        public string FakulteAdi { get; set; }
        public string UniversiteAdi { get; set; }
        public string IlAdi { get; set; }

        public string IlceAdi { get; set; }

        public string Aciklama { get; set; }



    }
}
