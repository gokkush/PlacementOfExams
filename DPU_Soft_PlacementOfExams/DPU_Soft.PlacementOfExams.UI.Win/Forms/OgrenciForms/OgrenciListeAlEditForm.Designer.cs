namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.OgrenciForms
{
    partial class OgrenciListeAlEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.dpuDataLayoutControl = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuDataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtDers = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuButtonEdit();
            this.grid = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridControl();
            this.tablo = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridView();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colOgrNo = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colOgrAdiSoyadi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuDataLayoutControl)).BeginInit();
            this.dpuDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(757, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // dpuDataLayoutControl
            // 
            this.dpuDataLayoutControl.Controls.Add(this.grid);
            this.dpuDataLayoutControl.Controls.Add(this.txtDers);
            this.dpuDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpuDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.dpuDataLayoutControl.Name = "dpuDataLayoutControl";
            this.dpuDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.dpuDataLayoutControl.Root = this.Root;
            this.dpuDataLayoutControl.Size = new System.Drawing.Size(757, 277);
            this.dpuDataLayoutControl.TabIndex = 2;
            this.dpuDataLayoutControl.Text = "dpuDataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 250D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 100D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
            this.Root.Size = new System.Drawing.Size(757, 277);
            this.Root.TextVisible = false;
            // 
            // txtDers
            // 
            this.txtDers.Id = null;
            this.txtDers.Location = new System.Drawing.Point(71, 84);
            this.txtDers.MenuManager = this.ribbonControl;
            this.txtDers.Name = "txtDers";
            this.txtDers.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtDers.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDers.Size = new System.Drawing.Size(187, 20);
            this.txtDers.StatusBarAciklama = null;
            this.txtDers.StatusBarKisayol = "F4: ";
            this.txtDers.StatusBarKisayolAciklama = null;
            this.txtDers.StyleController = this.dpuDataLayoutControl;
            this.txtDers.TabIndex = 4;
            // 
            // grid
            // 
            this.grid.Location = new System.Drawing.Point(262, 12);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(483, 253);
            this.grid.TabIndex = 5;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.colOgrNo,
            this.colOgrAdiSoyadi});
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
            this.tablo.ViewCaption = "Öğrenci Listesi";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.grid;
            this.layoutControlItem2.Location = new System.Drawing.Point(250, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.OptionsTableLayoutItem.RowSpan = 4;
            this.layoutControlItem2.Size = new System.Drawing.Size(487, 257);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // colOgrNo
            // 
            this.colOgrNo.Caption = "Öğrenci Numarası";
            this.colOgrNo.Name = "colOgrNo";
            this.colOgrNo.OptionsColumn.AllowEdit = false;
            this.colOgrNo.StatusBarAciklama = null;
            this.colOgrNo.StatusBarKisayol = null;
            this.colOgrNo.StatusBarKisayolAciklama = null;
            this.colOgrNo.Visible = true;
            this.colOgrNo.VisibleIndex = 0;
            this.colOgrNo.Width = 140;
            // 
            // colOgrAdiSoyadi
            // 
            this.colOgrAdiSoyadi.Caption = "Adı Soyadı";
            this.colOgrAdiSoyadi.Name = "colOgrAdiSoyadi";
            this.colOgrAdiSoyadi.OptionsColumn.AllowEdit = false;
            this.colOgrAdiSoyadi.StatusBarAciklama = null;
            this.colOgrAdiSoyadi.StatusBarKisayol = null;
            this.colOgrAdiSoyadi.StatusBarKisayolAciklama = null;
            this.colOgrAdiSoyadi.Visible = true;
            this.colOgrAdiSoyadi.VisibleIndex = 1;
            this.colOgrAdiSoyadi.Width = 316;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtDers;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem1.Size = new System.Drawing.Size(250, 185);
            this.layoutControlItem1.Text = "İlgili Ders:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(47, 13);
            // 
            // OgrenciListeAlEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 410);
            this.Controls.Add(this.dpuDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MaximumSize = new System.Drawing.Size(759, 411);
            this.MinimumSize = new System.Drawing.Size(759, 411);
            this.Name = "OgrenciListeAlEditForm";
            this.Text = "OgrenciListeAlEditForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.dpuDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuDataLayoutControl)).EndInit();
            this.dpuDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.DpuDataLayoutControl dpuDataLayoutControl;
        private UserControls.Controls.Grid.DpuGridControl grid;
        private UserControls.Controls.Grid.DpuGridView tablo;
        private UserControls.Controls.Grid.DpuGridColumn colOgrNo;
        private UserControls.Controls.Grid.DpuGridColumn colOgrAdiSoyadi;
        private UserControls.Controls.DpuButtonEdit txtDers;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}