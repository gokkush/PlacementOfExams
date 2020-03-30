using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.Model.Attributes
{
    public class ZorunluAlan:Attribute
    {
        public string Descriptiıon { get; }
        public string ControlName { get; }

        /// <summary>
        /// Validation (zorunlu alan kontrolleri) işlemleri
        /// </summary>
        /// <param name="description"></param> Mesajda gösterilecek açıklama
        /// <param name="controlName"></param> Uyarı Mesaj sonrasında focus yapılacak text alanı

        public ZorunluAlan(string description, string controlName)
        {
            Descriptiıon = description;
            ControlName = controlName;
        }
    }
}
