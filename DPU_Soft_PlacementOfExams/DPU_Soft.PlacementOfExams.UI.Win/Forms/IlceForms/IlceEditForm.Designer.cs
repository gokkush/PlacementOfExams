namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.IlceForms
{
    partial class IlceEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IlceEditForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
<<<<<<< HEAD
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.dpuDataLayoutControl = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuDataLayoutControl();
            this.tglDurum = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuToogleSwitch();
            this.txtAciklama = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuMemoEdit();
            this.txtIl = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuButtonEdit();
=======
            this.dpuDataLayoutControl = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuDataLayoutControl();
            this.tglDurum = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuToogleSwitch();
            this.txtAciklama = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuMemoEdit();
>>>>>>> yandal
            this.txtIlceAdi = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuTextEdit();
            this.txtKod = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DpuCodeTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
<<<<<<< HEAD
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
=======
>>>>>>> yandal
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuDataLayoutControl)).BeginInit();
            this.dpuDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).BeginInit();
=======
>>>>>>> yandal
            ((System.ComponentModel.ISupportInitialize)(this.txtIlceAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
=======
>>>>>>> yandal
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = ((int)(resources.GetObject("ribbonControl.SearchEditItem.EditWidth")));
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            resources.ApplyResources(this.ribbonControl, "ribbonControl");
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // dpuDataLayoutControl
            // 
            this.dpuDataLayoutControl.Controls.Add(this.tglDurum);
            this.dpuDataLayoutControl.Controls.Add(this.txtAciklama);
<<<<<<< HEAD
            this.dpuDataLayoutControl.Controls.Add(this.txtIl);
=======
>>>>>>> yandal
            this.dpuDataLayoutControl.Controls.Add(this.txtIlceAdi);
            this.dpuDataLayoutControl.Controls.Add(this.txtKod);
            resources.ApplyResources(this.dpuDataLayoutControl, "dpuDataLayoutControl");
            this.dpuDataLayoutControl.Name = "dpuDataLayoutControl";
            this.dpuDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.dpuDataLayoutControl.Root = this.Root;
            // 
            // tglDurum
            // 
            resources.ApplyResources(this.tglDurum, "tglDurum");
            this.tglDurum.MenuManager = this.ribbonControl;
            this.tglDurum.Name = "tglDurum";
            this.tglDurum.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglDurum.Properties.Appearance.Options.UseForeColor = true;
            this.tglDurum.Properties.AutoHeight = ((bool)(resources.GetObject("tglDurum.Properties.AutoHeight")));
            this.tglDurum.Properties.AutoWidth = true;
            this.tglDurum.Properties.GlyphAlignment = ((DevExpress.Utils.HorzAlignment)(resources.GetObject("tglDurum.Properties.GlyphAlignment")));
            this.tglDurum.Properties.OffText = resources.GetString("tglDurum.Properties.OffText");
            this.tglDurum.Properties.OnText = resources.GetString("tglDurum.Properties.OnText");
            this.tglDurum.StatusBarAciklama = "Kaydın kullanım durumunu belirleyiniz.";
            this.tglDurum.StyleController = this.dpuDataLayoutControl;
            // 
            // txtAciklama
            // 
            this.txtAciklama.EnterMoveNextControl = true;
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
<<<<<<< HEAD
            this.txtAciklama.Location = new System.Drawing.Point(78, 84);
=======
            this.txtAciklama.Location = new System.Drawing.Point(63, 60);
>>>>>>> yandal
=======
            resources.ApplyResources(this.txtAciklama, "txtAciklama");
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
            this.txtAciklama.MenuManager = this.ribbonControl;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtAciklama.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAciklama.Properties.MaxLength = 500;
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
<<<<<<< HEAD
            this.txtAciklama.Size = new System.Drawing.Size(308, 60);
=======
            this.txtAciklama.Size = new System.Drawing.Size(323, 84);
>>>>>>> yandal
=======
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
            this.txtAciklama.StatusBarAciklama = "Açıklama Giriniz.";
            this.txtAciklama.StyleController = this.dpuDataLayoutControl;
            // 
<<<<<<< HEAD
            // txtIl
            // 
            this.txtIl.Id = null;
            this.txtIl.Location = new System.Drawing.Point(78, 60);
            this.txtIl.MenuManager = this.ribbonControl;
            this.txtIl.Name = "txtIl";
            this.txtIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtIl.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtIl.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtIl.Size = new System.Drawing.Size(130, 20);
            this.txtIl.StatusBarAciklama = "İl Şeçimi Yapınız!";
            this.txtIl.StatusBarKisayol = "F4: ";
            this.txtIl.StatusBarKisayolAciklama = "İl Şeç";
            this.txtIl.StyleController = this.dpuDataLayoutControl;
            this.txtIl.TabIndex = 6;
            // 
            // txtIlceAdi
            // 
            this.txtIlceAdi.EnterMoveNextControl = true;
            this.txtIlceAdi.Location = new System.Drawing.Point(78, 36);
=======
            // txtIlceAdi
            // 
            this.txtIlceAdi.EnterMoveNextControl = true;
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
            this.txtIlceAdi.Location = new System.Drawing.Point(63, 36);
>>>>>>> yandal
=======
            resources.ApplyResources(this.txtIlceAdi, "txtIlceAdi");
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
            this.txtIlceAdi.MenuManager = this.ribbonControl;
            this.txtIlceAdi.Name = "txtIlceAdi";
            this.txtIlceAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtIlceAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtIlceAdi.Properties.MaxLength = 50;
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
<<<<<<< HEAD
            this.txtIlceAdi.Size = new System.Drawing.Size(308, 20);
=======
            this.txtIlceAdi.Size = new System.Drawing.Size(323, 20);
>>>>>>> yandal
=======
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
            this.txtIlceAdi.StatusBarAciklama = "İlçe Adı Giriniz!";
            this.txtIlceAdi.StyleController = this.dpuDataLayoutControl;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
<<<<<<< HEAD
            this.txtKod.Location = new System.Drawing.Point(78, 12);
=======
            this.txtKod.Location = new System.Drawing.Point(63, 12);
>>>>>>> yandal
=======
            resources.ApplyResources(this.txtKod, "txtKod");
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.Moccasin;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 20;
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
<<<<<<< HEAD
            this.txtKod.Size = new System.Drawing.Size(130, 20);
=======
            this.txtKod.Size = new System.Drawing.Size(145, 20);
>>>>>>> yandal
=======
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
            this.txtKod.StatusBarAciklama = "Kod Giriniz.";
            this.txtKod.StyleController = this.dpuDataLayoutControl;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
<<<<<<< HEAD
            this.layoutControlItem3,
=======
>>>>>>> yandal
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 99D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
<<<<<<< HEAD
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 100D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
=======
            rowDefinition3.Height = 100D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
>>>>>>> yandal
            this.Root.Size = new System.Drawing.Size(398, 156);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
            this.layoutControlItem1.Text = "İlçe Kodu:";
<<<<<<< HEAD
            this.layoutControlItem1.TextSize = new System.Drawing.Size(63, 13);
=======
=======
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 13);
>>>>>>> yandal
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtIlceAdi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(378, 24);
<<<<<<< HEAD:DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
            this.layoutControlItem2.Text = "İlçe Adı:";
<<<<<<< HEAD
            this.layoutControlItem2.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtIl;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Text = "Bulunduğu İl:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(63, 13);
=======
=======
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
>>>>>>> yandal:YEDEK-9/DPU_Soft_PlacementOfExams/DPU_Soft.PlacementOfExams.UI.Win/Forms/IlceForms/IlceEditForm.Designer.cs
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 13);
>>>>>>> yandal
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtAciklama;
<<<<<<< HEAD
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(378, 64);
            this.layoutControlItem4.Text = "Açıklama:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(63, 13);
=======
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(378, 88);
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 13);
>>>>>>> yandal
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.tglDurum;
            this.layoutControlItem5.Location = new System.Drawing.Point(279, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // IlceEditForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dpuDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.Name = "IlceEditForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.dpuDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpuDataLayoutControl)).EndInit();
            this.dpuDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).EndInit();
=======
>>>>>>> yandal
            ((System.ComponentModel.ISupportInitialize)(this.txtIlceAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
=======
>>>>>>> yandal
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.DpuDataLayoutControl dpuDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.DpuToogleSwitch tglDurum;
        private UserControls.Controls.DpuMemoEdit txtAciklama;
<<<<<<< HEAD
        private UserControls.Controls.DpuButtonEdit txtIl;
=======
>>>>>>> yandal
        private UserControls.Controls.DpuTextEdit txtIlceAdi;
        private UserControls.Controls.DpuCodeTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
<<<<<<< HEAD
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
=======
>>>>>>> yandal
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}