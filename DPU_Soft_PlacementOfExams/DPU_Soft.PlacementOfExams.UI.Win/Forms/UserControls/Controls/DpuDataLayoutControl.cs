using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraLayout.Utils;
using System.Windows.Forms;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class DpuDataLayoutControl: DataLayoutControl
    {
        public DpuDataLayoutControl()
        {
            OptionsFocus.EnableAutoTabOrder = false;

        }
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new ThisLayoutControlImplementor(this);
        }
    }

    internal class ThisLayoutControlImplementor : LayoutControlImplementor
    {
        public ThisLayoutControlImplementor(ILayoutControlOwner owner) : base(owner)
        {
        }

        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item= base.CreateLayoutItem(parent);
            item.AppearanceItemCaption.ForeColor = Color.Maroon;
            return item;
        }
        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var grp=base.CreateLayoutGroup(parent);
            grp.LayoutMode = LayoutMode.Table;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 200;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Percent;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 100;
            grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType=SizeType.Absolute,Width=99});
            grp.OptionsTableLayoutGroup.RowDefinitions.Clear();
            for (int i = 0; i < 9; i++)
            {
                grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Absolute,
                    Height = 24                
                });
                if (i+1 != 9)
                {
                    continue;
                }
                else
                {
                    grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                    {
                        SizeType = SizeType.Percent,
                        Height = 100
                    });
                }
            }
            return grp;
        }
    }


}
