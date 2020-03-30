using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DpuPhoneNoTextEdit:DpuTextEdit, IStatusBarAciklama
    {
        public DpuPhoneNoTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"0(\d?\d?\d?) \d?\d?\d? \d?\d? \d?\d";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Telefon No Giriniz";
        }
    }
}
