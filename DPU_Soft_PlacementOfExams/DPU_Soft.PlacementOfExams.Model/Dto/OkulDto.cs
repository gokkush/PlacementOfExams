using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPU_Soft.PlacementOfExams.Model.Dto
{
    [NotMapped]
<<<<<<< HEAD
<<<<<<< HEAD
    public class OkulS:Okul
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
=======
    public class OkulS:OkulEntity
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string UniversiteAdi { get; set; }
>>>>>>> yandal
=======
    public class OkulS:OkulEntity
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string UniversiteAdi { get; set; }
>>>>>>> yandal
    }

    public class OkulL :BaseEntity
    {
<<<<<<< HEAD
<<<<<<< HEAD
        public string UniversiteAdi { get; set; }
        public string FakulteAdi { get; set; }
=======
        public string FakulteAdi { get; set; }
        public string UniversiteAdi { get; set; }
>>>>>>> yandal
=======
        public string FakulteAdi { get; set; }
        public string UniversiteAdi { get; set; }
>>>>>>> yandal
        public string IlAdi { get; set; }

        public string IlceAdi { get; set; }

        public string Aciklama { get; set; }

    }
}
