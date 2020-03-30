using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DpuMailTextEdit: DpuTextEdit, IStatusBarAciklama
    {
        public DpuMailTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.RegEx;
            Properties.Mask.EditMask = @"((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
            Properties.Mask.AutoComplete = AutoCompleteType.Strong;
            StatusBarAciklama = "E-Mail Giriniz";
        }
    }
}
