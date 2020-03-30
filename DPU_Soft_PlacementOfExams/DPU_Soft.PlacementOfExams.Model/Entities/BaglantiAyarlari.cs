using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System.Security;

namespace DPU_Soft.PlacementOfExams.Model.Entities
{
    public class BaglantiAyarlari:BaseEntity
    {
        public string Server { get; set; }
        public YetkilendirmeTuru YetkilendirmeTuru { get; set; }
        public SecureString KullaniciAdi { get; set; }
        public SecureString Sifre { get; set; }
    }
}
