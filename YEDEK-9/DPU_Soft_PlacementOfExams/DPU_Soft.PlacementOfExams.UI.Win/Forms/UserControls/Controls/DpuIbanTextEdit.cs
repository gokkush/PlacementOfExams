using DevExpress.XtraEditors.Mask;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DpuIbanTextEdit: DpuTextEdit, IStatusBarAciklama
    {
        public DpuIbanTextEdit()
        {
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"TR\d?\d \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Iban No Giriniz";
        }

    }
}
