using DevExpress.XtraEditors;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System.Drawing;
using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DpuCheckedComboboxEdit:CheckedComboBoxEdit,IStatusBarKisayol
    {
        public DpuCheckedComboboxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightSkyBlue;
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; } = "F4 : ";

        public string StatusBarKisayolAciklama { get; set; }
    }


}
