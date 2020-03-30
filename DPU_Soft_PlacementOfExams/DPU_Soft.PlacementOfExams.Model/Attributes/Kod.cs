using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPU_Soft.PlacementOfExams.Model.Attributes
{
    public class Kod:Attribute
    {
        public string Descriptiıon { get; }
        public string ControlName { get; }
        
        /// <summary>
        /// Kod alanlarında aynı kodun olup olmadığını kontrol etmek
        /// </summary>

        public Kod(string description, string controlName)
        {
            Descriptiıon = description;
            ControlName = controlName;

        }
    }
}
