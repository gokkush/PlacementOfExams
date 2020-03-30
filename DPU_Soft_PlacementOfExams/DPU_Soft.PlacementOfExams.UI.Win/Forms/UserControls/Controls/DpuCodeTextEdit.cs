using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DpuCodeTextEdit:DpuTextEdit, IStatusBarAciklama
    {
        public DpuCodeTextEdit()
        {
            Properties.Appearance.BackColor = Color.LightSkyBlue;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaxLength = 20;
            StatusBarAciklama = "Kod Giriniz.";
        }
    }
}
