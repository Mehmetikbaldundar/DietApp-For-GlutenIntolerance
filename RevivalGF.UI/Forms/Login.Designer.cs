
    ﻿namespace RevivalGF.UI.Forms

{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pbNext = new System.Windows.Forms.PictureBox();

            this.tbPassword = new System.Windows.Forms.TextBox();

            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbLogin.Controls.Add(this.pictureBox2);
            this.gbLogin.Controls.Add(this.lblRegister);
            this.gbLogin.Controls.Add(this.lblInfo);
            this.gbLogin.Controls.Add(this.pbNext);

            this.gbLogin.Controls.Add(this.tbPassword);


            this.gbLogin.Controls.Add(this.tbUsername);
            this.gbLogin.Controls.Add(this.label4);
            this.gbLogin.Controls.Add(this.label3);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.label1);

            this.gbLogin.Location = new System.Drawing.Point(146, 79);

            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(485, 238);
            this.gbLogin.TabIndex = 3;
            this.gbLogin.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(254, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegister.ForeColor = System.Drawing.Color.Blue;
            this.lblRegister.Location = new System.Drawing.Point(161, 201);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(269, 16);
            this.lblRegister.TabIndex = 7;
            this.lblRegister.Text = "If you do not have an account, click to register.";

            this.lblRegister.DoubleClick += new System.EventHandler(this.lblRegister_DoubleClick);

            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.Location = new System.Drawing.Point(40, 158);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(187, 16);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Wrong username or password.";
            // 
            // pbNext
            // 
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(83, 181);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(54, 51);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 6;
            this.pbNext.TabStop = false;

            this.pbNext.DoubleClick += new System.EventHandler(this.pbNext_DoubleClick);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.SeaShell;
            this.tbPassword.Location = new System.Drawing.Point(44, 133);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(204, 22);
            this.tbPassword.TabIndex = 4;



            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.SeaShell;
            this.tbUsername.Location = new System.Drawing.Point(44, 83);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(204, 22);
            this.tbUsername.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Revival GF app!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

            this.Name = "Login";
            this.Text = "Login";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pbNext;

        private System.Windows.Forms.TextBox tbPassword;

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}