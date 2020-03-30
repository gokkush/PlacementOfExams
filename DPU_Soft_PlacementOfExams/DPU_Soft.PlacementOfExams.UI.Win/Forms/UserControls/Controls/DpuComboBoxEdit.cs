using DevExpress.XtraEditors;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
   public class DpuComboBoxEdit:ComboBoxEdit, IStatusBarKisayol
    {
        [ToolboxItem(true)]
        public DpuComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightSkyBlue;
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;

        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; } = "F4 : ";

        public string StatusBarKisayolAciklama { get; set; }
    }
}
