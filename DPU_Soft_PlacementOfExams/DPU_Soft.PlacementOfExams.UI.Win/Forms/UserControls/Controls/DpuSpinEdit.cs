using DevExpress.XtraEditors;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System.Drawing;
using DevExpress.Utils;
using System;
using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
    public class DpuSpinEdit:SpinEdit, IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public DpuSpinEdit()
        {
            Properties.Appearance.BackColor = Color.LightSkyBlue;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "d";
        }
        public override bool EnterMoveNextControl { get; set; }

        public string StatusBarAciklama { get; set; }
    }
}
