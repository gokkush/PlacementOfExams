using DevExpress.XtraEditors;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    class DpuHyperLinkLabelControl : HyperlinkLabelControl, IStatusBarAciklama
    {
        public DpuHyperLinkLabelControl()
        {
            Cursor = Cursors.Hand;
            LinkBehavior = LinkBehavior.NeverUnderline;

        }
        public string StatusBarAciklama { get; set ; }
    }
}
