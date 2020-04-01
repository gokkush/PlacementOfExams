namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DersSecFormTable
{
    partial class DersTable
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
            this.colKod = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colDersAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 20);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(495, 205);
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
            this.colKod,
            this.colDersAdi});
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
            this.tablo.StatusBarAciklama = "Dersler";
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Ders Kartları";
            // 
            // colKod
            // 
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKod.OptionsFilter.AllowAutoFilter = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisayol = null;
            this.colKod.StatusBarKisayolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 123;
            // 
            // colDersAdi
            // 
            this.colDersAdi.Caption = "Ders Adı";
            this.colDersAdi.FieldName = "DersAdi";
            this.colDersAdi.Name = "colDersAdi";
            this.colDersAdi.OptionsColumn.AllowEdit = false;
            this.colDersAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDersAdi.OptionsColumn.FixedWidth = true;
            this.colDersAdi.OptionsFilter.AllowAutoFilter = false;
            this.colDersAdi.StatusBarAciklama = null;
            this.colDersAdi.StatusBarKisayol = null;
            this.colDersAdi.StatusBarKisayolAciklama = null;
            this.colDersAdi.Visible = true;
            this.colDersAdi.VisibleIndex = 1;
            this.colDersAdi.Width = 146;
            // 
            // DersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "DersTable";
            this.Controls.SetChildIndex(this.ınsUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Grid.DpuGridControl grid;
        protected internal Grid.DpuGridView tablo;
        private Grid.DpuGridColumn colKod;
        private Grid.DpuGridColumn colDersAdi;
    }
}
