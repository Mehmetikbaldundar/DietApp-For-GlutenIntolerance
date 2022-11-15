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
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNext
            // 
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Image = global::RevivalGF.UI.Properties.Resources.nextbutton;
            this.pbNext.Location = new System.Drawing.Point(788, 485);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(95, 87);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 7;
            this.pbNext.TabStop = false;
            this.pbNext.DoubleClick += new System.EventHandler(this.pbNext_DoubleClick);
            // 
            // cbReport
            // 
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Location = new System.Drawing.Point(772, 28);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(138, 24);
            this.cbReport.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(522, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please select report type:";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.BackColor = System.Drawing.Color.Transparent;
            this.lblReport.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReport.Location = new System.Drawing.Point(87, 23);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(128, 34);
            this.lblReport.TabIndex = 5;
            this.lblReport.Text = "Daily Report";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RevivalGF.UI.Properties.Resources.register_background;
            this.ClientSize = new System.Drawing.Size(996, 595);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.cbReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReport);
            this.MaximumSize = new System.Drawing.Size(1014, 642);
            this.MinimumSize = new System.Drawing.Size(1014, 642);
            this.Name = "Reports";
            this.Text = "Reports";
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