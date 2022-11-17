namespace RevivalGF.UI.Forms
{
    partial class Medication
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
            this.tbMedicationName = new System.Windows.Forms.TextBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudOneDay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgwMedicines = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOneDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMedicationName
            // 
            this.tbMedicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMedicationName.Location = new System.Drawing.Point(43, 73);
            this.tbMedicationName.Name = "tbMedicationName";
            this.tbMedicationName.Size = new System.Drawing.Size(202, 30);
            this.tbMedicationName.TabIndex = 28;
            // 
            // pbNext
            // 
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Image = global::RevivalGF.UI.Properties.Resources.sustenium;
            this.pbNext.Location = new System.Drawing.Point(667, 375);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(115, 88);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 26;
            this.pbNext.TabStop = false;
            this.pbNext.DoubleClick += new System.EventHandler(this.pbNext_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 23;
            this.label3.Text = "Thank you!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "How many times a day will you take medicine?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "If there is a pill you use that you want us to track, please enter its name:";
            // 
            // nudOneDay
            // 
            this.nudOneDay.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudOneDay.Location = new System.Drawing.Point(43, 157);
            this.nudOneDay.Name = "nudOneDay";
            this.nudOneDay.Size = new System.Drawing.Size(62, 35);
            this.nudOneDay.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "How many days will you take medicine?";
            // 
            // nudDays
            // 
            this.nudDays.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudDays.Location = new System.Drawing.Point(43, 236);
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(62, 35);
            this.nudDays.TabIndex = 29;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(43, 328);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 40);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgwMedicines
            // 
            this.dgwMedicines.BackgroundColor = System.Drawing.Color.Snow;
            this.dgwMedicines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwMedicines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgwMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMedicines.Location = new System.Drawing.Point(399, 157);
            this.dgwMedicines.Name = "dgwMedicines";
            this.dgwMedicines.RowHeadersWidth = 51;
            this.dgwMedicines.RowTemplate.Height = 24;
            this.dgwMedicines.Size = new System.Drawing.Size(333, 197);
            this.dgwMedicines.TabIndex = 31;
            // 
            // Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RevivalGF.UI.Properties.Resources.medicationform;
            this.ClientSize = new System.Drawing.Size(821, 504);
            this.Controls.Add(this.dgwMedicines);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudDays);
            this.Controls.Add(this.nudOneDay);
            this.Controls.Add(this.tbMedicationName);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(839, 551);
            this.MinimumSize = new System.Drawing.Size(839, 551);
            this.Name = "Medication";
            this.Text = "Medication";
            this.Load += new System.EventHandler(this.Medication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOneDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMedicationName;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudOneDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgwMedicines;
    }
}