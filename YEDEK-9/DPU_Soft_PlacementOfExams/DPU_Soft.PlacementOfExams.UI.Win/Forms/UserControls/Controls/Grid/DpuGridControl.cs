using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DPU_Soft.PlacementOfExams.UI.Win.Interfaces;
using System.ComponentModel;
using System;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Registrator;

namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid
{
    [ToolboxItem(true)]
    public class DpuGridControl:GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (GridView)CreateView("DpuGridView");
            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f,FontStyle.Bold);

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

            var idColumn = new DpuGridColumn
            {
                Caption = "Id",
                FieldName = "Id"
            };
            idColumn.OptionsColumn.AllowEdit = false;
            idColumn.OptionsColumn.ShowInCustomizationForm = false;
            view.Columns.Add(idColumn);

            var kodColumn = new DpuGridColumn {
                Caption = "Kod",
                FieldName = "Kod"
            };
            kodColumn.OptionsColumn.AllowEdit = false;
            kodColumn.Visible = true;
            kodColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            kodColumn.AppearanceCell.Options.UseTextOptions = true;
            view.Columns.Add(kodColumn);

            return view;
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new DpuGridInfoRegistrator());
        }

        private class DpuGridInfoRegistrator : GridInfoRegistrator
        {
            public override string ViewName
            {
                get
                {
                    return "DpuGridView";
                }
            }
            public override BaseView CreateView(GridControl grid)
            {
                return new DpuGridView(grid);
            }
        }
    }

    public class DpuGridView:GridView, IStatusBarKisayol
    {

        #region Properties
        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; }

        public string StatusBarKisayolAciklama { get; set; }
        #endregion

        public DpuGridView(){ }
        public DpuGridView(GridControl ownerGrid) : base(ownerGrid) { }

        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);
            if (column.ColumnEdit == null) return;
            if(column.ColumnEdit.GetType()==typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }

        protected override GridColumnCollection CreateColumnCollection()
        {
            return new DpuGridColumnCollection(this);
        }

        private class DpuGridColumnCollection : GridColumnCollection
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

    public class DpuGridColumn : GridColumn, IStatusBarKisayol
    {
        #region Properties
        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; }

        public string StatusBarKisayolAciklama { get; set; } 
        #endregion
    }
}
