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
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(40, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(474, 355);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Activity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 144);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnAddAct
            // 
            this.btnAddAct.BackColor = System.Drawing.Color.Snow;
            this.btnAddAct.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAct.Location = new System.Drawing.Point(402, 70);
            this.btnAddAct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAct.Name = "btnAddAct";
            this.btnAddAct.Size = new System.Drawing.Size(56, 37);
            this.btnAddAct.TabIndex = 13;
            this.btnAddAct.Text = "Add";
            this.btnAddAct.UseVisualStyleBackColor = false;
            this.btnAddAct.Click += new System.EventHandler(this.btnAddAct_Click);
            // 
            // btnDeleteAct
            // 
            this.btnDeleteAct.BackColor = System.Drawing.Color.Snow;
            this.btnDeleteAct.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteAct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteAct.Location = new System.Drawing.Point(313, 70);
            this.btnDeleteAct.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAct.Name = "btnDeleteAct";
            this.btnDeleteAct.Size = new System.Drawing.Size(72, 37);
            this.btnDeleteAct.TabIndex = 12;
            this.btnDeleteAct.Text = "Delete";
            this.btnDeleteAct.UseVisualStyleBackColor = false;
            this.btnDeleteAct.Click += new System.EventHandler(this.btnDeleteAct_Click);
            // 
            // cbActivity
            // 
            this.cbActivity.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbActivity.FormattingEnabled = true;
            this.cbActivity.Location = new System.Drawing.Point(161, 55);
            this.cbActivity.Margin = new System.Windows.Forms.Padding(2);
            this.cbActivity.Name = "cbActivity";
            this.cbActivity.Size = new System.Drawing.Size(138, 27);
            this.cbActivity.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 54);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 27);
            this.label13.TabIndex = 4;
            this.label13.Text = "Select Activity:";
            // 
            // tbDuration
            // 
            this.tbDuration.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDuration.Location = new System.Drawing.Point(244, 102);
            this.tbDuration.Margin = new System.Windows.Forms.Padding(2);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(55, 27);
            this.tbDuration.TabIndex = 0;
            this.tbDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDuration_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(43, 145);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 24);
            this.label20.TabIndex = 4;
            this.label20.Text = "Calorie:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 99);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 27);
            this.label14.TabIndex = 4;
            this.label14.Text = "Enter the duration (min):";
            // 
            // lblSportCalorie
            // 
            this.lblSportCalorie.AutoSize = true;
            this.lblSportCalorie.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSportCalorie.Location = new System.Drawing.Point(104, 145);
            this.lblSportCalorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSportCalorie.Name = "lblSportCalorie";
            this.lblSportCalorie.Size = new System.Drawing.Size(51, 24);
            this.lblSportCalorie.TabIndex = 4;
            this.lblSportCalorie.Text = "0 kcal";
            // 
            // pbNext
            // 
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Image = global::RevivalGF.UI.Properties.Resources.sustenium;
            this.pbNext.Location = new System.Drawing.Point(618, 379);
            this.pbNext.Margin = new System.Windows.Forms.Padding(2);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(106, 88);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 11;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // Activitytab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RevivalGF.UI.Properties.Resources.main;
            this.ClientSize = new System.Drawing.Size(728, 474);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(744, 513);
            this.MinimumSize = new System.Drawing.Size(744, 513);
            this.Name = "Activitytab";
            this.Text = "Activity";
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