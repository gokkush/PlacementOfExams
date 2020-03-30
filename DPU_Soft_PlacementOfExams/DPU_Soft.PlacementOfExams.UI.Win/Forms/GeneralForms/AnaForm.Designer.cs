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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnOkulKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnIlKartlari = new DevExpress.XtraBars.BarButtonItem();
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
            this.ribbonControl.SearchEditItem,
            this.btnOkulKartlari,
            this.btnIlKartlari});
            resources.ApplyResources(this.ribbonControl, "ribbonControl");
            this.ribbonControl.MaxItemId = 3;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rPTanimlar});
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // btnOkulKartlari
            // 
            resources.ApplyResources(this.btnOkulKartlari, "btnOkulKartlari");
            this.btnOkulKartlari.Id = 1;
            this.btnOkulKartlari.Name = "btnOkulKartlari";
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnOkulKartlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOkulKartlari_ItemClick);
=======
>>>>>>> yandal
=======
>>>>>>> yandal
            // 
            // btnIlKartlari
            // 
            resources.ApplyResources(this.btnIlKartlari, "btnIlKartlari");
            this.btnIlKartlari.Id = 2;
            this.btnIlKartlari.Name = "btnIlKartlari";
            // 
            // rPTanimlar
            // 
            this.rPTanimlar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rPCAnaTanim});
            this.rPTanimlar.Name = "rPTanimlar";
            resources.ApplyResources(this.rPTanimlar, "rPTanimlar");
            // 
            // rPCAnaTanim
            // 
            this.rPCAnaTanim.ItemLinks.Add(this.btnOkulKartlari);
            this.rPCAnaTanim.ItemLinks.Add(this.btnIlKartlari);
            this.rPCAnaTanim.Name = "rPCAnaTanim";
            resources.ApplyResources(this.rPCAnaTanim, "rPCAnaTanim");
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // AnaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.Image = global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources.placement_icon;
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
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
        private DevExpress.XtraBars.BarButtonItem btnIlKartlari;
    }
}