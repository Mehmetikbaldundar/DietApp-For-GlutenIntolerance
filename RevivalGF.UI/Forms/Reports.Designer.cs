namespace RevivalGF.UI.Forms
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNext
            // 
            resources.ApplyResources(this.pbNext, "pbNext");
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Image = global::RevivalGF.UI.Properties.Resources.nextbutton;
            this.pbNext.Name = "pbNext";
            this.pbNext.TabStop = false;
            this.pbNext.DoubleClick += new System.EventHandler(this.pbNext_DoubleClick);
            // 
            // cbReport
            // 
            resources.ApplyResources(this.cbReport, "cbReport");
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Name = "cbReport";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // lblReport
            // 
            resources.ApplyResources(this.lblReport, "lblReport");
            this.lblReport.BackColor = System.Drawing.Color.Transparent;
            this.lblReport.Name = "lblReport";
            // 
            // Reports
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RevivalGF.UI.Properties.Resources.register_background;
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.cbReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReport);
            this.Name = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.ComboBox cbReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReport;
    }
}