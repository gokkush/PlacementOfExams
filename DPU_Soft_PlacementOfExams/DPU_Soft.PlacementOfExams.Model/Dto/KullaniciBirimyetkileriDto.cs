using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPU_Soft.PlacementOfExams.Model.Dto
{
    [NotMapped]
    public class KullaniciBirimYetkileriL : KullaniciBirimYetkileriEntity, IBaseHareketEntity
    {
        public string Kod { get; set; }
        public string  SubeAdi { get; set; }
        public string DonemAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
