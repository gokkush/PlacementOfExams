namespace DPU_Soft.PlacementOfExams.UI.Win.Forms.UserControls.Controls.Navigators
{
    partial class smallNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(smallNavigator));
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.controlNavigator1.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.controlNavigator1.Appearance.Options.UseFont = true;
            this.controlNavigator1.Appearance.Options.UseForeColor = true;
            this.controlNavigator1.Buttons.Append.Visible = false;
            this.controlNavigator1.Buttons.CancelEdit.Visible = false;
            this.controlNavigator1.Buttons.Edit.Visible = false;
            this.controlNavigator1.Buttons.EndEdit.Visible = false;
            this.controlNavigator1.Buttons.First.ImageIndex = 0;
            this.controlNavigator1.Buttons.ImageList = this.imageCollection;
            this.controlNavigator1.Buttons.Last.ImageIndex = 1;
            this.controlNavigator1.Buttons.Next.ImageIndex = 2;
            this.controlNavigator1.Buttons.NextPage.Visible = false;
            this.controlNavigator1.Buttons.Prev.ImageIndex = 3;
            this.controlNavigator1.Buttons.PrevPage.Visible = false;
            this.controlNavigator1.Buttons.Remove.Visible = false;
            this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator1.Location = new System.Drawing.Point(0, 0);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.Size = new System.Drawing.Size(584, 24);
            this.controlNavigator1.TabIndex = 0;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.controlNavigator1.TextStringFormat = "Kayıt ( {0} / {1} )";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertImage(global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources.first_16x162, "first_16x162", typeof(global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources), 0);
            this.imageCollection.Images.SetKeyName(0, "first_16x162");
            this.imageCollection.InsertImage(global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources.last_16x162, "last_16x162", typeof(global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources), 1);
            this.imageCollection.Images.SetKeyName(1, "last_16x162");
            this.imageCollection.InsertImage(global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources.next_16x162, "next_16x162", typeof(global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources), 2);
            this.imageCollection.Images.SetKeyName(2, "next_16x162");
            this.imageCollection.InsertImage(global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources.prev_16x162, "prev_16x162", typeof(global::DPU_Soft.PlacementOfExams.UI.Win.Properties.Resources), 3);
            this.imageCollection.Images.SetKeyName(3, "prev_16x162");
            // 
            // smallNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlNavigator1);
            this.Name = "smallNavigator";
            this.Size = new System.Drawing.Size(584, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}
