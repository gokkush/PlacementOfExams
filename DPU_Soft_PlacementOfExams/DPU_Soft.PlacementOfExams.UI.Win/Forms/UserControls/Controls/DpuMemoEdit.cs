using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using DevExpress.XtraEditors;
using System.Drawing;
using System;
using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DpuMemoEdit: MemoEdit, IStatusBarAciklama
    {

        public DpuMemoEdit()
        {
            Properties.Appearance.BackColor = Color.LightSkyBlue;
            Properties.MaxLength = 500;
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; } = "Açıklama Giriniz.";
        
    }
}
