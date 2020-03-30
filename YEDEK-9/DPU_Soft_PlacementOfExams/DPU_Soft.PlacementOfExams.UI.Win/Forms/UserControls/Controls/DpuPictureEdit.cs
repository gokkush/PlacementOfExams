using DevExpress.XtraEditors;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System.Drawing;
using System;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DpuPictureEdit: PictureEdit, IStatusBarKisayol
    {
        public DpuPictureEdit()
        {
            Properties.Appearance.BackColor = Color.LightSkyBlue;
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.NullText = "Resim Yok";
            Properties.SizeMode = PictureSizeMode.Stretch;
            Properties.ShowMenu = false;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        
        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; } = "F4 : ";

        public string StatusBarKisayolAciklama { get; set; }
        
    }
}
