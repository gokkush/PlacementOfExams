using DevExpress.XtraEditors;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DpuFilterControl: FilterControl,IStatusBarAciklama
    {
        public DpuFilterControl()
        {
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; }
    }
}
