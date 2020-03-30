using DevExpress.XtraEditors;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System.ComponentModel;
using DevExpress.Utils;
using System.Drawing;
using System;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DpuToogleSwitch:ToggleSwitch, IStatusBarAciklama
    {
        public DpuToogleSwitch()
        {
            Name = "tglDurum";
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;
        }
        public override bool EnterMoveNextControl { get; set; }

        public string StatusBarAciklama { get; set; } = "Kaydın kullanım durumunu belirleyiniz.";
    }
}
