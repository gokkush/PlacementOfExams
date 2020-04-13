using DevExpress.DataAccess.ObjectBinding;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPU_Soft.PlacementOfExams.Model.Dto
{
    [NotMapped]
    public class SinavSalonBilgileriL : SinavSalonBilgileri, IBaseHareketEntity
    {
        public string SalonAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
    [HighlightedClass]
    public class SinavSalonBilgileriR
    {
        public long SinavSalonuId { get; set; }
        public string SalonAdi { get; set; }

    }
}
