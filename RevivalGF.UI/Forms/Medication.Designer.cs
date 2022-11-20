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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medication));
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOneDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMedicationName
            // 
            resources.ApplyResources(this.tbMedicationName, "tbMedicationName");
            this.tbMedicationName.Name = "tbMedicationName";
            // 
            // pbNext
            // 
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Image = global::RevivalGF.UI.Properties.Resources.sustenium;
            resources.ApplyResources(this.pbNext, "pbNext");
            this.pbNext.Name = "pbNext";
            this.pbNext.TabStop = false;
            this.pbNext.DoubleClick += new System.EventHandler(this.pbNext_DoubleClick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // nudOneDay
            // 
            resources.ApplyResources(this.nudOneDay, "nudOneDay");
            this.nudOneDay.Name = "nudOneDay";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // nudDays
            // 
            resources.ApplyResources(this.nudDays, "nudDays");
            this.nudDays.Name = "nudDays";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgwMedicines
            // 
            this.dgwMedicines.BackgroundColor = System.Drawing.Color.Snow;
            this.dgwMedicines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwMedicines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgwMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMedicines.GridColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.dgwMedicines, "dgwMedicines");
            this.dgwMedicines.Name = "dgwMedicines";
            this.dgwMedicines.RowTemplate.Height = 24;
            this.dgwMedicines.SelectionChanged += new System.EventHandler(this.dgwMedicines_SelectionChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Medication
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RevivalGF.UI.Properties.Resources.medicationform;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgwMedicines);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudDays);
            this.Controls.Add(this.nudOneDay);
            this.Controls.Add(this.tbMedicationName);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Medication";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
    }
}