﻿using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPU_Soft.PlacementOfExams.Model.Dto
{
    [NotMapped]
    public class SinavKayitS:SinavKayitEntity
    {
        public string DersAdi { get; set; }
        public string SubeAdi { get; set; }
        public string DonemAdi { get; set; }
    }
    public class SinavKayitL : BaseEntity
    {
        public string SinavAdi { get; set; }
        public string DersAdi { get; set; }
        public SinavTuru SinavTuru { get; set; }
        public string SubeAdi { get; set; }
        public string DonemAdi { get; set; }
        public bool Durum { get; set; }
    }
}