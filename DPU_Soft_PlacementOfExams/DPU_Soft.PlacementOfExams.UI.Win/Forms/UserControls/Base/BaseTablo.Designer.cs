namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Base
{
    partial class BaseTablo
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
            this.components = new System.ComponentModel.Container();
            this.ınsUptNavigator = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Navigators.InsUptNavigator();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnHareketEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnHareketSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnHareketDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.btnTabloYenile = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ınsUptNavigator
            // 
            this.ınsUptNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ınsUptNavigator.Location = new System.Drawing.Point(0, 225);
            this.ınsUptNavigator.Name = "ınsUptNavigator";
            this.ınsUptNavigator.Size = new System.Drawing.Size(495, 24);
            this.ınsUptNavigator.TabIndex = 0;
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHareketEkle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHareketSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHareketDuzenle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTabloYenile)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // btnHareketEkle
            // 
            this.btnHareketEkle.Caption = "Hareket Ekle";
            this.btnHareketEkle.Id = 0;
            this.btnHareketEkle.ImageOptions.Image = global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources.addfile_16x16;
            this.btnHareketEkle.Name = "btnHareketEkle";
            // 
            // btnHareketSil
            // 
            this.btnHareketSil.Caption = "Hakreket Sil";
            this.btnHareketSil.Id = 2;
            this.btnHareketSil.ImageOptions.Image = global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources.deletelist_16x16;
            this.btnHareketSil.Name = "btnHareketSil";
            // 
            // btnHareketDuzenle
            // 
            this.btnHareketDuzenle.Caption = "Hareket Düzenle";
            this.btnHareketDuzenle.Id = 3;
            this.btnHareketDuzenle.ImageOptions.Image = global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources.edit_16x16;
            this.btnHareketDuzenle.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnHareketDuzenle.Name = "btnHareketDuzenle";
            this.btnHareketDuzenle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnTabloYenile
            // 
            this.btnTabloYenile.Caption = "Verileri Yenile";
            this.btnTabloYenile.Id = 4;
            this.btnTabloYenile.ImageOptions.Image = global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources.recurrence_16x16;
            this.btnTabloYenile.ImageOptions.LargeImage = global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources.recurrence_32x32;
            this.btnTabloYenile.Name = "btnTabloYenile";
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnHareketEkle,
            this.btnHareketSil,
            this.btnHareketDuzenle,
            this.btnTabloYenile});
            this.barManager.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(495, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 249);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(495, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 249);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(495, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 249);
            // 
            // BaseTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ınsUptNavigator);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BaseTablo";
            this.Size = new System.Drawing.Size(495, 249);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Controls.Navigators.InsUptNavigator ınsUptNavigator;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        protected internal DevExpress.XtraBars.PopupMenu popupMenu;
        protected internal DevExpress.XtraBars.BarManager barManager;
        protected internal DevExpress.XtraBars.BarButtonItem btnHareketEkle;
        protected internal DevExpress.XtraBars.BarButtonItem btnHareketSil;
        protected DevExpress.XtraBars.BarButtonItem btnHareketDuzenle;
        public DevExpress.XtraBars.BarButtonItem btnTabloYenile;
    }
}
