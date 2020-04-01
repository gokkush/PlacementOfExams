namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.DersForms
{
    partial class DersYetkiEditForm
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
            this.dersTable = new DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.DersSecFormTable.DersTable();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(579, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // dersTable
            // 
            this.dersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dersTable.Location = new System.Drawing.Point(0, 109);
            this.dersTable.Name = "dersTable";
            this.dersTable.Size = new System.Drawing.Size(579, 215);
            this.dersTable.TabIndex = 2;
            // 
            // DersYetkiEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 348);
            this.Controls.Add(this.dersTable);
            this.IconOptions.ShowIcon = false;
            this.Name = "DersYetkiEditForm";
            this.Text = "DersYetkiEditForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.dersTable, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.DersSecFormTable.DersTable dersTable;
    }
}