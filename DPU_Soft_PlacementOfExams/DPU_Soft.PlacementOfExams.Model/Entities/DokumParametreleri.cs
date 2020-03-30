using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class DokumParametreleri:IBaseEntity
    {
        public string RaporBaslik { get; set; }
        public EvetHayir BaslikEkle { get; set; }

        public RaporuKagidaSigdir RaporKagidaSigdirma { get; set; }

        public YazdirmaYonu YazdirmaYonu { get; set; }
        public EvetHayir YatayCizgileriGoster { get; set; }

        public EvetHayir DikeyCizgileriGoster { get; set; }

        public EvetHayir SutunBasliklariniGoster { get; set; }

        public string YaziciciAdi { get; set; }

        public int YazdirilacakAdet { get; set; }

        public DokumSekli DokumSekli { get; set; }


    }
}
