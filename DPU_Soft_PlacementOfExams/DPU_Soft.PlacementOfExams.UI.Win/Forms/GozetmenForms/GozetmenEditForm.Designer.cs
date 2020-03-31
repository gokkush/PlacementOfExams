namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GozetmenForms
{
    partial class GozetmenEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition9 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition10 = new DevExpress.XtraLayout.RowDefinition();
            this.dpuDataLayoutControl = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuDataLayoutControl();
            this.txtGorevlendirmeSayisi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuSpinEdit();
            this.txtGozetmenSoyadi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuTextEdit();
            this.txtAciklama = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuMemoEdit();
            this.txtGozetmenAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuTextEdit();
            this.tglDurum = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuToogleSwitch();
            this.txtKod = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuCodeTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuDataLayoutControl)).BeginInit();
            this.dpuDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorevlendirmeSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGozetmenSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGozetmenAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(448, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // dpuDataLayoutControl
            // 
            this.dpuDataLayoutControl.Controls.Add(this.txtGorevlendirmeSayisi);
            this.dpuDataLayoutControl.Controls.Add(this.txtGozetmenSoyadi);
            this.dpuDataLayoutControl.Controls.Add(this.txtAciklama);
            this.dpuDataLayoutControl.Controls.Add(this.txtGozetmenAdi);
            this.dpuDataLayoutControl.Controls.Add(this.tglDurum);
            this.dpuDataLayoutControl.Controls.Add(this.txtKod);
            this.dpuDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpuDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.dpuDataLayoutControl.Name = "dpuDataLayoutControl";
            this.dpuDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.dpuDataLayoutControl.Root = this.Root;
            this.dpuDataLayoutControl.Size = new System.Drawing.Size(448, 156);
            this.dpuDataLayoutControl.TabIndex = 0;
            this.dpuDataLayoutControl.Text = "dpuDataLayoutControl";
            // 
            // txtGorevlendirmeSayisi
            // 
            this.txtGorevlendirmeSayisi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGorevlendirmeSayisi.Location = new System.Drawing.Point(149, 84);
            this.txtGorevlendirmeSayisi.MenuManager = this.ribbonControl;
            this.txtGorevlendirmeSayisi.Name = "txtGorevlendirmeSayisi";
            this.txtGorevlendirmeSayisi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtGorevlendirmeSayisi.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtGorevlendirmeSayisi.Properties.Appearance.Options.UseBackColor = true;
            this.txtGorevlendirmeSayisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGorevlendirmeSayisi.Properties.Mask.EditMask = "d";
            this.txtGorevlendirmeSayisi.Size = new System.Drawing.Size(109, 20);
            this.txtGorevlendirmeSayisi.StatusBarAciklama = null;
            this.txtGorevlendirmeSayisi.StyleController = this.dpuDataLayoutControl;
            this.txtGorevlendirmeSayisi.TabIndex = 2;
            // 
            // txtGozetmenSoyadi
            // 
            this.txtGozetmenSoyadi.EnterMoveNextControl = true;
            this.txtGozetmenSoyadi.Location = new System.Drawing.Point(149, 60);
            this.txtGozetmenSoyadi.MenuManager = this.ribbonControl;
            this.txtGozetmenSoyadi.Name = "txtGozetmenSoyadi";
            this.txtGozetmenSoyadi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtGozetmenSoyadi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtGozetmenSoyadi.Properties.MaxLength = 50;
            this.txtGozetmenSoyadi.Size = new System.Drawing.Size(287, 20);
            this.txtGozetmenSoyadi.StatusBarAciklama = null;
            this.txtGozetmenSoyadi.StyleController = this.dpuDataLayoutControl;
            this.txtGozetmenSoyadi.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.EnterMoveNextControl = true;
            this.txtAciklama.Location = new System.Drawing.Point(149, 108);
            this.txtAciklama.MenuManager = this.ribbonControl;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtAciklama.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAciklama.Properties.MaxLength = 500;
            this.txtAciklama.Size = new System.Drawing.Size(287, 36);
            this.txtAciklama.StatusBarAciklama = "Açıklama Giriniz.";
            this.txtAciklama.StyleController = this.dpuDataLayoutControl;
            this.txtAciklama.TabIndex = 3;
            // 
            // txtGozetmenAdi
            // 
            this.txtGozetmenAdi.EnterMoveNextControl = true;
            this.txtGozetmenAdi.Location = new System.Drawing.Point(149, 36);
            this.txtGozetmenAdi.MenuManager = this.ribbonControl;
            this.txtGozetmenAdi.Name = "txtGozetmenAdi";
            this.txtGozetmenAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtGozetmenAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtGozetmenAdi.Properties.MaxLength = 50;
            this.txtGozetmenAdi.Size = new System.Drawing.Size(287, 20);
            this.txtGozetmenAdi.StatusBarAciklama = "İl Adı Giriniz!";
            this.txtGozetmenAdi.StyleController = this.dpuDataLayoutControl;
            this.txtGozetmenAdi.TabIndex = 0;
            // 
            // tglDurum
            // 
            this.tglDurum.Location = new System.Drawing.Point(341, 12);
            this.tglDurum.MenuManager = this.ribbonControl;
            this.tglDurum.Name = "tglDurum";
            this.tglDurum.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglDurum.Properties.Appearance.Options.UseForeColor = true;
            this.tglDurum.Properties.AutoHeight = false;
            this.tglDurum.Properties.AutoWidth = true;
            this.tglDurum.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglDurum.Properties.OffText = "Pasif";
            this.tglDurum.Properties.OnText = "Aktif";
            this.tglDurum.Size = new System.Drawing.Size(77, 20);
            this.tglDurum.StatusBarAciklama = "Kaydın kullanım durumunu belirleyiniz.";
            this.tglDurum.StyleController = this.dpuDataLayoutControl;
            this.tglDurum.TabIndex = 4;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(149, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.Moccasin;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 20;
            this.txtKod.Size = new System.Drawing.Size(109, 20);
            this.txtKod.StatusBarAciklama = "Kod Giriniz.";
            this.txtKod.StyleController = this.dpuDataLayoutControl;
            this.txtKod.TabIndex = 5;
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
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 250D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition5.Width = 100D;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition6.Width = 99D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition4,
            columnDefinition5,
            columnDefinition6});
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition7.Height = 24D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition8.Height = 24D;
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition9.Height = 24D;
            rowDefinition9.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition10.Height = 100D;
            rowDefinition10.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition6,
            rowDefinition7,
            rowDefinition8,
            rowDefinition9,
            rowDefinition10});
            this.Root.Size = new System.Drawing.Size(448, 156);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(250, 24);
            this.layoutControlItem1.Text = "Gözetmen Kodu:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(134, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.tglDurum;
            this.layoutControlItem2.Location = new System.Drawing.Point(329, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem2.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtGozetmenAdi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(428, 24);
            this.layoutControlItem3.Text = "Gözetmen Adı:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(134, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtAciklama;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem4.Size = new System.Drawing.Size(428, 40);
            this.layoutControlItem4.Text = "Açıklama:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(134, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtGozetmenSoyadi;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(428, 24);
            this.layoutControlItem5.Text = "Gözetmen Soyadı:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(134, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtGorevlendirmeSayisi;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem6.Size = new System.Drawing.Size(250, 24);
            this.layoutControlItem6.Text = "Kaç Sınava Görevlendirildiği:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(134, 13);
            // 
            // GozetmenEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 289);
            this.Controls.Add(this.dpuDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(450, 290);
            this.Name = "GozetmenEditForm";
            this.Text = "Gözetmen Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.dpuDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuDataLayoutControl)).EndInit();
            this.dpuDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGorevlendirmeSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGozetmenSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGozetmenAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.DpuDataLayoutControl dpuDataLayoutControl;
        private UserControls.Controls.DpuMemoEdit txtAciklama;
        private UserControls.Controls.DpuTextEdit txtGozetmenAdi;
        private UserControls.Controls.DpuToogleSwitch tglDurum;
        private UserControls.Controls.DpuCodeTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private UserControls.Controls.DpuTextEdit txtGozetmenSoyadi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private UserControls.Controls.DpuSpinEdit txtGorevlendirmeSayisi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}