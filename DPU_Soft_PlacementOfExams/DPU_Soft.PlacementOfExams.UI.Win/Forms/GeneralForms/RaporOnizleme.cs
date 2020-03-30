using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    public partial class RaporOnizleme : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public RaporOnizleme(params object[] prm)
        {
            InitializeComponent();
            RaporGosterici.PrintingSystem = (PrintingSystem)prm[0];
            Text = $"{Text} ({prm[1].ToString()})";
        }
    }
}