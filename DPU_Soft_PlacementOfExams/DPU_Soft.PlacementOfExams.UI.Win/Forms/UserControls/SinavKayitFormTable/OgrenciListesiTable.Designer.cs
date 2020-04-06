namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.SinavKayitFormTable
{
    partial class OgrenciListesiTable
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
            this.colOgrenciNo = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colOgrenciAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colOgrenciBolum = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.colOgrenciDers = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
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
            this.colOgrenciNo,
            this.colOgrenciAdi,
            this.colOgrenciBolum,
            this.colOgrenciDers});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsSelection.MultiSelect = true;
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
            // colOgrenciNo
            // 
            this.colOgrenciNo.Caption = "Öğrenci Numarası";
            this.colOgrenciNo.FieldName = "OgrenciNo";
            this.colOgrenciNo.Name = "colOgrenciNo";
            this.colOgrenciNo.OptionsColumn.AllowEdit = false;
            this.colOgrenciNo.StatusBarAciklama = null;
            this.colOgrenciNo.StatusBarKisayol = null;
            this.colOgrenciNo.StatusBarKisayolAciklama = null;
            this.colOgrenciNo.Visible = true;
            this.colOgrenciNo.VisibleIndex = 0;
            this.colOgrenciNo.Width = 99;
            // 
            // colOgrenciAdi
            // 
            this.colOgrenciAdi.Caption = "Öğrenci Adı";
            this.colOgrenciAdi.FieldName = "OgrenciAdi";
            this.colOgrenciAdi.Name = "colOgrenciAdi";
            this.colOgrenciAdi.OptionsColumn.AllowEdit = false;
            this.colOgrenciAdi.StatusBarAciklama = null;
            this.colOgrenciAdi.StatusBarKisayol = null;
            this.colOgrenciAdi.StatusBarKisayolAciklama = null;
            this.colOgrenciAdi.Visible = true;
            this.colOgrenciAdi.VisibleIndex = 1;
            this.colOgrenciAdi.Width = 131;
            // 
            // colOgrenciBolum
            // 
            this.colOgrenciBolum.Caption = "Bölümü";
            this.colOgrenciBolum.FieldName = "OgrenciBolum";
            this.colOgrenciBolum.Name = "colOgrenciBolum";
            this.colOgrenciBolum.OptionsColumn.AllowEdit = false;
            this.colOgrenciBolum.StatusBarAciklama = null;
            this.colOgrenciBolum.StatusBarKisayol = null;
            this.colOgrenciBolum.StatusBarKisayolAciklama = null;
            this.colOgrenciBolum.Visible = true;
            this.colOgrenciBolum.VisibleIndex = 2;
            this.colOgrenciBolum.Width = 183;
            // 
            // colOgrenciDers
            // 
            this.colOgrenciDers.Caption = "Öğrencinin Kayıtlı Olduğu Ders";
            this.colOgrenciDers.FieldName = "OgrenciDers";
            this.colOgrenciDers.Name = "colOgrenciDers";
            this.colOgrenciDers.OptionsColumn.AllowEdit = false;
            this.colOgrenciDers.StatusBarAciklama = null;
            this.colOgrenciDers.StatusBarKisayol = null;
            this.colOgrenciDers.StatusBarKisayolAciklama = null;
            this.colOgrenciDers.Visible = true;
            this.colOgrenciDers.VisibleIndex = 3;
            this.colOgrenciDers.Width = 186;
            // 
            // OgrenciListesiTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "OgrenciListesiTable";
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
        private Controls.Grid.DpuGridColumn colOgrenciNo;
        private Controls.Grid.DpuGridColumn colOgrenciAdi;
        private Controls.Grid.DpuGridColumn colOgrenciBolum;
        private Controls.Grid.DpuGridColumn colOgrenciDers;
    }
}
