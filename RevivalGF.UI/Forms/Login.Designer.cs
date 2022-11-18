
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
            resources.ApplyResources(this.gbLogin, "gbLogin");
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
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackgroundImage = global::RevivalGF.UI.Properties.Resources.sustenium;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // lblRegister
            // 
            resources.ApplyResources(this.lblRegister, "lblRegister");
            this.lblRegister.ForeColor = System.Drawing.Color.Blue;
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.DoubleClick += new System.EventHandler(this.lblRegister_DoubleClick);
            // 
            // lblInfo
            // 
            resources.ApplyResources(this.lblInfo, "lblInfo");
            this.lblInfo.Name = "lblInfo";
            // 
            // pbNext
            // 
            resources.ApplyResources(this.pbNext, "pbNext");
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Image = global::RevivalGF.UI.Properties.Resources.nextbutton;
            this.pbNext.Name = "pbNext";
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            this.pbNext.DoubleClick += new System.EventHandler(this.pbNext_DoubleClick);
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.BackColor = System.Drawing.Color.SeaShell;
            this.tbPassword.Name = "tbPassword";
            // 
            // tbUsername
            // 
            resources.ApplyResources(this.tbUsername, "tbUsername");
            this.tbUsername.BackColor = System.Drawing.Color.SeaShell;
            this.tbUsername.Name = "tbUsername";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RevivalGF.UI.Properties.Resources.Backgroundimageforlogin;
            this.Controls.Add(this.gbLogin);
            this.Name = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
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