namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    partial class RaporSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporSecim));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.dpuDataLayoutControl = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuDataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtYaziciAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuComboBoxEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtYazdirmaSekli = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuComboBoxEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtYazdirilacakAdet = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuSpinEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.grid = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridControl();
            this.tablo = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridView();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colRaporAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Grid.DpuGridColumn();
            this.smallNavigator1 = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Navigators.smallNavigator();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dpuPictureEdit1 = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuPictureEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuDataLayoutControl)).BeginInit();
            this.dpuDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYaziciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYazdirmaSekli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYazdirilacakAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuPictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(678, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // dpuDataLayoutControl
            // 
            this.dpuDataLayoutControl.Controls.Add(this.dpuPictureEdit1);
            this.dpuDataLayoutControl.Controls.Add(this.smallNavigator1);
            this.dpuDataLayoutControl.Controls.Add(this.grid);
            this.dpuDataLayoutControl.Controls.Add(this.txtYazdirilacakAdet);
            this.dpuDataLayoutControl.Controls.Add(this.txtYazdirmaSekli);
            this.dpuDataLayoutControl.Controls.Add(this.txtYaziciAdi);
            this.dpuDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpuDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.dpuDataLayoutControl.Name = "dpuDataLayoutControl";
            this.dpuDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.dpuDataLayoutControl.Root = this.Root;
            this.dpuDataLayoutControl.Size = new System.Drawing.Size(678, 386);
            this.dpuDataLayoutControl.TabIndex = 2;
            this.dpuDataLayoutControl.Text = "dpuDataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 270D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 40D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 100D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
            this.Root.Size = new System.Drawing.Size(678, 386);
            this.Root.TextVisible = false;
            // 
            // txtYaziciAdi
            // 
            this.txtYaziciAdi.EnterMoveNextControl = true;
            this.txtYaziciAdi.Location = new System.Drawing.Point(309, 12);
            this.txtYaziciAdi.MenuManager = this.ribbonControl;
            this.txtYaziciAdi.Name = "txtYaziciAdi";
            this.txtYaziciAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtYaziciAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtYaziciAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtYaziciAdi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtYaziciAdi.Size = new System.Drawing.Size(357, 20);
            this.txtYaziciAdi.StatusBarAciklama = null;
            this.txtYaziciAdi.StatusBarKisayol = "F4 : ";
            this.txtYaziciAdi.StatusBarKisayolAciklama = null;
            this.txtYaziciAdi.StyleController = this.dpuDataLayoutControl;
            this.txtYaziciAdi.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtYaziciAdi;
            this.layoutControlItem1.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem1.Size = new System.Drawing.Size(458, 24);
            this.layoutControlItem1.Text = "Yazıcı Adı:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(85, 13);
            // 
            // txtYazdirmaSekli
            // 
            this.txtYazdirmaSekli.EnterMoveNextControl = true;
            this.txtYazdirmaSekli.Location = new System.Drawing.Point(309, 36);
            this.txtYazdirmaSekli.MenuManager = this.ribbonControl;
            this.txtYazdirmaSekli.Name = "txtYazdirmaSekli";
            this.txtYazdirmaSekli.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtYazdirmaSekli.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtYazdirmaSekli.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtYazdirmaSekli.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtYazdirmaSekli.Size = new System.Drawing.Size(169, 20);
            this.txtYazdirmaSekli.StatusBarAciklama = null;
            this.txtYazdirmaSekli.StatusBarKisayol = "F4 : ";
            this.txtYazdirmaSekli.StatusBarKisayolAciklama = null;
            this.txtYazdirmaSekli.StyleController = this.dpuDataLayoutControl;
            this.txtYazdirmaSekli.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtYazdirmaSekli;
            this.layoutControlItem2.Location = new System.Drawing.Point(200, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(270, 24);
            this.layoutControlItem2.Text = "Yazdırma Şekli:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 13);
            // 
            // txtYazdirilacakAdet
            // 
            this.txtYazdirilacakAdet.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtYazdirilacakAdet.Location = new System.Drawing.Point(619, 36);
            this.txtYazdirilacakAdet.MenuManager = this.ribbonControl;
            this.txtYazdirilacakAdet.Name = "txtYazdirilacakAdet";
            this.txtYazdirilacakAdet.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtYazdirilacakAdet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtYazdirilacakAdet.Properties.Mask.EditMask = "d";
            this.txtYazdirilacakAdet.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtYazdirilacakAdet.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtYazdirilacakAdet.Size = new System.Drawing.Size(47, 20);
            this.txtYazdirilacakAdet.StatusBarAciklama = null;
            this.txtYazdirilacakAdet.StyleController = this.dpuDataLayoutControl;
            this.txtYazdirilacakAdet.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtYazdirilacakAdet;
            this.layoutControlItem3.Location = new System.Drawing.Point(510, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(148, 24);
            this.layoutControlItem3.Text = "Yazdırılacak Adet:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(85, 13);
            // 
            // grid
            // 
            this.grid.Location = new System.Drawing.Point(212, 60);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(454, 290);
            this.grid.TabIndex = 7;
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
            this.colRaporAdi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsMenu.ShowAutoFilterRowItem = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Rapor Seçimi";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.grid;
            this.layoutControlItem4.Location = new System.Drawing.Point(200, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(458, 294);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // colRaporAdi
            // 
            this.colRaporAdi.Caption = "Rapor Adı";
            this.colRaporAdi.FieldName = "RaporAdi";
            this.colRaporAdi.Name = "colRaporAdi";
            this.colRaporAdi.OptionsColumn.AllowEdit = false;
            this.colRaporAdi.StatusBarAciklama = null;
            this.colRaporAdi.StatusBarKisayol = null;
            this.colRaporAdi.StatusBarKisayolAciklama = null;
            this.colRaporAdi.Visible = true;
            this.colRaporAdi.VisibleIndex = 0;
            // 
            // smallNavigator1
            // 
            this.smallNavigator1.Location = new System.Drawing.Point(212, 354);
            this.smallNavigator1.Name = "smallNavigator1";
            this.smallNavigator1.Size = new System.Drawing.Size(454, 20);
            this.smallNavigator1.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.smallNavigator1;
            this.layoutControlItem5.Location = new System.Drawing.Point(200, 342);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem5.Size = new System.Drawing.Size(458, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // dpuPictureEdit1
            // 
            this.dpuPictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dpuPictureEdit1.EditValue = ((object)(resources.GetObject("dpuPictureEdit1.EditValue")));
            this.dpuPictureEdit1.EnterMoveNextControl = true;
            this.dpuPictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.dpuPictureEdit1.MenuManager = this.ribbonControl;
            this.dpuPictureEdit1.Name = "dpuPictureEdit1";
            this.dpuPictureEdit1.Properties.AllowFocused = false;
            this.dpuPictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.dpuPictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.dpuPictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.dpuPictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.dpuPictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dpuPictureEdit1.Properties.NullText = "Resim Yok";
            this.dpuPictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.dpuPictureEdit1.Properties.ShowMenu = false;
            this.dpuPictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.dpuPictureEdit1.Size = new System.Drawing.Size(196, 362);
            this.dpuPictureEdit1.StatusBarAciklama = null;
            this.dpuPictureEdit1.StatusBarKisayol = "F4 : ";
            this.dpuPictureEdit1.StatusBarKisayolAciklama = null;
            this.dpuPictureEdit1.StyleController = this.dpuDataLayoutControl;
            this.dpuPictureEdit1.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.dpuPictureEdit1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowSpan = 4;
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 366);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // RaporSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 519);
            this.Controls.Add(this.dpuDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MaximumSize = new System.Drawing.Size(680, 520);
            this.MinimumSize = new System.Drawing.Size(680, 520);
            this.Name = "RaporSecim";
            this.Text = "Rapor Seçimi";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.dpuDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuDataLayoutControl)).EndInit();
            this.dpuDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYaziciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYazdirmaSekli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYazdirilacakAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuPictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.DpuDataLayoutControl dpuDataLayoutControl;
        private UserControls.Controls.DpuPictureEdit dpuPictureEdit1;
        private UserControls.Controls.Navigators.smallNavigator smallNavigator1;
        private UserControls.Controls.Grid.DpuGridControl grid;
        private UserControls.Controls.Grid.DpuGridView tablo;
        private UserControls.Controls.Grid.DpuGridColumn colRaporAdi;
        private UserControls.Controls.DpuSpinEdit txtYazdirilacakAdet;
        private UserControls.Controls.DpuComboBoxEdit txtYazdirmaSekli;
        private UserControls.Controls.DpuComboBoxEdit txtYaziciAdi;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}