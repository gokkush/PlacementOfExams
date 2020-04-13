using DevExpress.DataAccess.ObjectBinding;
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
    public class OgrenciBilgileriL:OgrenciBilgileri, IBaseHareketEntity
    {

        public string SalonAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
    [HighlightedClass]
    public class OgrenciBilgileriR
    {
        public long SinavSalonuId { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciBolum { get; set; }
        public string OgrenciDers { get; set; }
        public string OgrenciNo { get; set; }
        public string SalonAdi { get; set; }
        public int SiraNo { get; set; }
    }
}

