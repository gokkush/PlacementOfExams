using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.ComponentModel;
using DevExpress.XtraGrid.Registrator;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid
{
    [ToolboxItem(true)]
    public class DpuBandedGridControl: GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (DpuBandedGridView)CreateView("DpuBandedGridView");
            view.Appearance.BandPanel.ForeColor = Color.DarkBlue;
            view.Appearance.BandPanel.Font= new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            view.Appearance.BandPanel.TextOptions.HAlignment= HorzAlignment.Center;
            view.BandPanelRowHeight = 40;

            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;

            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = true;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;

            var columns = new[]
            { new BandedGridColumn
            {
                Caption = "Id",
                FieldName = "Id",
                OptionsColumn= {AllowEdit=false,ShowInCustomizationForm=false}
            },

            new BandedGridColumn
            {
                Caption="Kod",
                FieldName="Kod",
                Visible=true,
                OptionsColumn= {AllowEdit=false},
                AppearanceCell= {TextOptions= { HAlignment = HorzAlignment.Center }, Options = {UseTextOptions=true}}
            }

            };

            view.Columns.AddRange(columns);

            return view;
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new DpuBandedGridInfoRegistrator());
        }

        private class DpuBandedGridInfoRegistrator : BandedGridInfoRegistrator
        {
            public override string ViewName
            {
                get
                {
                    return "DpuBandedGridView";
                }
            }
            public override BaseView CreateView(GridControl grid)
            {
                return new DpuBandedGridView(grid);
            }
        }
    }

    public class DpuBandedGridView :BandedGridView,IStatusBarKisayol
    {
        #region Properties
        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; }

        public string StatusBarKisayolAciklama { get; set; }
        #endregion

        public DpuBandedGridView() {  }

        public DpuBandedGridView(GridControl ownerGrid) : base(ownerGrid)
        {
        }

        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);
            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }

        protected override GridColumnCollection CreateColumnCollection()
        {
            return new DpuGridColumnCollection(this);
        }

        private class DpuGridColumnCollection : BandedGridColumnCollection
        {
            public DpuGridColumnCollection(ColumnView view) : base(view)
            {
            }
            protected override GridColumn CreateColumn()
            {
                var column = new DpuGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
    }

    public class DpuBandedGridColumn : BandedGridColumn, IStatusBarKisayol
    {
        #region Properties
        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; }

        public string StatusBarKisayolAciklama { get; set; } 
        #endregion


    }


}
