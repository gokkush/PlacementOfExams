namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.GeneralForms
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnOkulKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.rPTanimlar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rPCAnaTanim = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ALC = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnOkulKartlari,
            this.ribbonControl.SearchEditItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 2;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rPTanimlar});
            this.ribbonControl.Size = new System.Drawing.Size(893, 158);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // btnOkulKartlari
            // 
            this.btnOkulKartlari.Caption = "Üniversite Kaydı";
            this.btnOkulKartlari.Id = 1;
            this.btnOkulKartlari.Name = "btnOkulKartlari";
            this.btnOkulKartlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOkulKartlari_ItemClick);
            // 
            // rPTanimlar
            // 
            this.rPTanimlar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rPCAnaTanim});
            this.rPTanimlar.Name = "rPTanimlar";
            this.rPTanimlar.Text = "Tanımlamalar";
            // 
            // rPCAnaTanim
            // 
            this.rPCAnaTanim.ItemLinks.Add(this.btnOkulKartlari);
            this.rPCAnaTanim.Name = "rPCAnaTanim";
            this.rPCAnaTanim.Text = "Ana Tanımlamalar";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 454);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(893, 24);
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 478);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.Image = global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources.placement_icon;
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "PlacementOfExams";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage rPTanimlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rPCAnaTanim;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Alerter.AlertControl ALC;
        private DevExpress.XtraBars.BarButtonItem btnOkulKartlari;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
    }
}