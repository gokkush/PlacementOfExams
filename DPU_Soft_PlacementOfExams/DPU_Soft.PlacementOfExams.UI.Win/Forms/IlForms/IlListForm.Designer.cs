namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.IlForms
{
    partial class IlListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IlListForm));
            this.longNavigator = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Navigators.LongNavigator();
            this.grid = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridControl();
            this.tablo = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridView();
            this.colId = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colKod = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colIlAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colAciklama = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlForms/IlListForm.Designer.cs
<<<<<<< HEAD
=======

>>>>>>> yandal
=======
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlForms/IlListForm.Designer.cs
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
<<<<<<< HEAD
=======
            this.ribbonControl.MaxItemId = 43;
>>>>>>> yandal
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = ((int)(resources.GetObject("ribbonControl.SearchEditItem.EditWidth")));
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
<<<<<<< HEAD
            this.ribbonControl.Size = new System.Drawing.Size(818, 109);
=======
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlForms/IlListForm.Designer.cs
            this.ribbonControl.Size = new System.Drawing.Size(936, 109);
>>>>>>> yandal
=======
            resources.ApplyResources(this.ribbonControl, "ribbonControl");
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlForms/IlListForm.Designer.cs
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator
            // 
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlForms/IlListForm.Designer.cs
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
<<<<<<< HEAD
            this.longNavigator.Location = new System.Drawing.Point(0, 247);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(818, 24);
=======
            this.longNavigator.Location = new System.Drawing.Point(0, 248);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(936, 24);
>>>>>>> yandal
            this.longNavigator.TabIndex = 2;
=======
            resources.ApplyResources(this.longNavigator, "longNavigator");
            this.longNavigator.Name = "longNavigator";
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlForms/IlListForm.Designer.cs
            // 
            // grid
            // 
            resources.ApplyResources(this.grid, "grid");
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlForms/IlListForm.Designer.cs
<<<<<<< HEAD
            this.grid.Size = new System.Drawing.Size(818, 138);
=======
            this.grid.Size = new System.Drawing.Size(936, 139);
>>>>>>> yandal
            this.grid.TabIndex = 3;
=======
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlForms/IlListForm.Designer.cs
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = ((System.Drawing.Font)(resources.GetObject("tablo.Appearance.FooterPanel.Font")));
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKod,
            this.colIlAdi,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            resources.ApplyResources(this.tablo, "tablo");
            // 
            // colId
            // 
            resources.ApplyResources(this.colId, "colId");
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisayol = null;
            this.colId.StatusBarKisayolAciklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.colKod, "colKod");
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisayol = null;
            this.colKod.StatusBarKisayolAciklama = null;
            // 
            // colIlAdi
            // 
            resources.ApplyResources(this.colIlAdi, "colIlAdi");
            this.colIlAdi.FieldName = "IlAdi";
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.StatusBarAciklama = null;
            this.colIlAdi.StatusBarKisayol = null;
            this.colIlAdi.StatusBarKisayolAciklama = null;
            // 
            // colAciklama
            // 
            resources.ApplyResources(this.colAciklama, "colAciklama");
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisayol = null;
            this.colAciklama.StatusBarKisayolAciklama = null;
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlForms/IlListForm.Designer.cs
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 389;
<<<<<<< HEAD
=======

>>>>>>> yandal
=======
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlForms/IlListForm.Designer.cs
            // 
            // IlListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlForms/IlListForm.Designer.cs
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(818, 295);
=======
            this.ClientSize = new System.Drawing.Size(936, 296);
>>>>>>> yandal
=======
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlForms/IlListForm.Designer.cs
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "IlListForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.Navigators.LongNavigator longNavigator;
        private UserControls.Controls.Grid.DpuGridControl grid;
        private UserControls.Controls.Grid.DpuGridView tablo;
        private UserControls.Controls.Grid.DpuGridColumn colId;
        private UserControls.Controls.Grid.DpuGridColumn colKod;
        private UserControls.Controls.Grid.DpuGridColumn colIlAdi;
        private UserControls.Controls.Grid.DpuGridColumn colAciklama;
    }
}