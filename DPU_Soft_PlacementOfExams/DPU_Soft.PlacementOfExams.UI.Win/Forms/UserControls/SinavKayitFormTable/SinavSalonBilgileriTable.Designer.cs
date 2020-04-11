namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.SinavKayitFormTable
{
    partial class SinavSalonBilgileriTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridControl();
            this.tablo = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridView();
            this.colSalonAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colSalonKapasitesi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.GozetmenSayisi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.barManager;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(495, 225);
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
            this.colSalonAdi,
            this.colSalonKapasitesi,
            this.GozetmenSayisi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Salon Ekleme Modülü";
            // 
            // colSalonAdi
            // 
            this.colSalonAdi.Caption = "Salon Adı";
            this.colSalonAdi.FieldName = "SalonAdi";
            this.colSalonAdi.Name = "colSalonAdi";
            this.colSalonAdi.OptionsColumn.AllowEdit = false;
            this.colSalonAdi.StatusBarAciklama = null;
            this.colSalonAdi.StatusBarKisayol = null;
            this.colSalonAdi.StatusBarKisayolAciklama = null;
            this.colSalonAdi.Visible = true;
            this.colSalonAdi.VisibleIndex = 0;
            this.colSalonAdi.Width = 813;
            // 
            // colSalonKapasitesi
            // 
            this.colSalonKapasitesi.Caption = "Salon Kapasitesi";
            this.colSalonKapasitesi.FieldName = "SalonKapasitesi";
            this.colSalonKapasitesi.Name = "colSalonKapasitesi";
            this.colSalonKapasitesi.StatusBarAciklama = null;
            this.colSalonKapasitesi.StatusBarKisayol = null;
            this.colSalonKapasitesi.StatusBarKisayolAciklama = null;
            this.colSalonKapasitesi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalonKapasitesi", "{0:0}")});
            this.colSalonKapasitesi.Visible = true;
            this.colSalonKapasitesi.VisibleIndex = 1;
            this.colSalonKapasitesi.Width = 78;
            // 
            // GozetmenSayisi
            // 
            this.GozetmenSayisi.Caption = "Gözetmen Sayısı";
            this.GozetmenSayisi.FieldName = "GozetmenSayisi";
            this.GozetmenSayisi.Name = "GozetmenSayisi";
            this.GozetmenSayisi.StatusBarAciklama = null;
            this.GozetmenSayisi.StatusBarKisayol = null;
            this.GozetmenSayisi.StatusBarKisayolAciklama = null;
            this.GozetmenSayisi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GozetmenSayisi", "{0:0}")});
            this.GozetmenSayisi.Visible = true;
            this.GozetmenSayisi.VisibleIndex = 2;
            this.GozetmenSayisi.Width = 65;
            // 
            // SinavSalonBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "SinavSalonBilgileriTable";
            this.Controls.SetChildIndex(this.ınsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Grid.DpuGridControl grid;
        private Controls.Grid.DpuGridView tablo;
        private Controls.Grid.DpuGridColumn colSalonAdi;
        private Controls.Grid.DpuGridColumn colSalonKapasitesi;
        private Controls.Grid.DpuGridColumn GozetmenSayisi;
    }
}
