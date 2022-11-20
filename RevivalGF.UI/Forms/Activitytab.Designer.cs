namespace RevivalGF.UI.Forms
{
    partial class Activitytab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activitytab));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddAct = new System.Windows.Forms.Button();
            this.btnDeleteAct = new System.Windows.Forms.Button();
            this.cbActivity = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSportCalorie = new System.Windows.Forms.Label();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnAddAct);
            this.groupBox2.Controls.Add(this.btnDeleteAct);
            this.groupBox2.Controls.Add(this.cbActivity);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbDuration);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblSportCalorie);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnAddAct
            // 
            resources.ApplyResources(this.btnAddAct, "btnAddAct");
            this.btnAddAct.BackColor = System.Drawing.Color.Snow;
            this.btnAddAct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAct.Name = "btnAddAct";
            this.btnAddAct.UseVisualStyleBackColor = false;
            this.btnAddAct.Click += new System.EventHandler(this.btnAddAct_Click);
            // 
            // btnDeleteAct
            // 
            resources.ApplyResources(this.btnDeleteAct, "btnDeleteAct");
            this.btnDeleteAct.BackColor = System.Drawing.Color.Snow;
            this.btnDeleteAct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteAct.Name = "btnDeleteAct";
            this.btnDeleteAct.UseVisualStyleBackColor = false;
            this.btnDeleteAct.Click += new System.EventHandler(this.btnDeleteAct_Click);
            // 
            // cbActivity
            // 
            resources.ApplyResources(this.cbActivity, "cbActivity");
            this.cbActivity.FormattingEnabled = true;
            this.cbActivity.Name = "cbActivity";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // tbDuration
            // 
            resources.ApplyResources(this.tbDuration, "tbDuration");
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDuration_KeyPress);
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // lblSportCalorie
            // 
            resources.ApplyResources(this.lblSportCalorie, "lblSportCalorie");
            this.lblSportCalorie.Name = "lblSportCalorie";
            // 
            // pbNext
            // 
            resources.ApplyResources(this.pbNext, "pbNext");
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Image = global::RevivalGF.UI.Properties.Resources.sustenium;
            this.pbNext.Name = "pbNext";
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // Activitytab
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RevivalGF.UI.Properties.Resources.main;
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.groupBox2);
            this.Name = "Activitytab";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Activitytab_FormClosed);
            this.Load += new System.EventHandler(this.Activity_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddAct;
        private System.Windows.Forms.Button btnDeleteAct;
        public System.Windows.Forms.ComboBox cbActivity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSportCalorie;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}