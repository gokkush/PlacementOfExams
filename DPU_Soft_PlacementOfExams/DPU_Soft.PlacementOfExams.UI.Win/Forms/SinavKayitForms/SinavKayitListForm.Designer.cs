namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.SinavKayitForms
{
    partial class SinavKayitListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinavKayitListForm));
            this.longNavigator = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Navigators.LongNavigator();
            this.grid = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridControl();
            this.tablo = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridView();
            this.colId = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colKod = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colSinavAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colDersAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colSinavTuru = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colAciklama = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
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
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 336);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(976, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(976, 227);
            this.grid.TabIndex = 3;
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
            this.colId,
            this.colKod,
            this.colSinavAdi,
            this.colDersAdi,
            this.colSinavTuru,
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
            this.tablo.ViewCaption = "Sınav Kayıtları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
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
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisayol = null;
            this.colKod.StatusBarKisayolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 112;
            // 
            // colSinavAdi
            // 
            this.colSinavAdi.Caption = "Sınav Adı";
            this.colSinavAdi.FieldName = "SinavAdi";
            this.colSinavAdi.Name = "colSinavAdi";
            this.colSinavAdi.OptionsColumn.AllowEdit = false;
            this.colSinavAdi.StatusBarAciklama = null;
            this.colSinavAdi.StatusBarKisayol = null;
            this.colSinavAdi.StatusBarKisayolAciklama = null;
            this.colSinavAdi.Visible = true;
            this.colSinavAdi.VisibleIndex = 1;
            this.colSinavAdi.Width = 190;
            // 
            // colDersAdi
            // 
            this.colDersAdi.Caption = "DersAdi";
            this.colDersAdi.FieldName = "DersAdi";
            this.colDersAdi.Name = "colDersAdi";
            this.colDersAdi.OptionsColumn.AllowEdit = false;
            this.colDersAdi.StatusBarAciklama = null;
            this.colDersAdi.StatusBarKisayol = null;
            this.colDersAdi.StatusBarKisayolAciklama = null;
            this.colDersAdi.Visible = true;
            this.colDersAdi.VisibleIndex = 2;
            this.colDersAdi.Width = 195;
            // 
            // colSinavTuru
            // 
            this.colSinavTuru.Caption = "Sınav Türü";
            this.colSinavTuru.FieldName = "SinavTuru";
            this.colSinavTuru.Name = "colSinavTuru";
            this.colSinavTuru.OptionsColumn.AllowEdit = false;
            this.colSinavTuru.StatusBarAciklama = null;
            this.colSinavTuru.StatusBarKisayol = null;
            this.colSinavTuru.StatusBarKisayolAciklama = null;
            this.colSinavTuru.Visible = true;
            this.colSinavTuru.VisibleIndex = 3;
            this.colSinavTuru.Width = 133;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisayol = null;
            this.colAciklama.StatusBarKisayolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            // 
            // SinavKayitListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 384);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "SinavKayitListForm";
            this.Text = "Sınav Kayıtları";
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
        private UserControls.Controls.Grid.DpuGridColumn colSinavAdi;
        private UserControls.Controls.Grid.DpuGridColumn colDersAdi;
        private UserControls.Controls.Grid.DpuGridColumn colSinavTuru;
        private UserControls.Controls.Grid.DpuGridColumn colAciklama;
    }
}