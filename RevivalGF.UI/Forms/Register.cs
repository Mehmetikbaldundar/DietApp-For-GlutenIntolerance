using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevivalGF.UI.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
            #region RegisterFormControl
            if (cbAccepted.Checked)
            {
                if (tbUsername.Text != "" && tbEmail.Text != "" && tbPassword.Text != "" && tbPassword.Text == tbRepeatPassword.Text && tbHeight.Text != "" && tbWeight.Text != "" && tbAge.Text != "" && cbActivityLevel.SelectedIndex != 0 && cbGoal.SelectedIndex != 0 && cbDisease.SelectedIndex != 0)
                {
                    //cinsiyet kontrolü eklenecek
                    //parola kontrolü eklenecektir (min 8 karakter özel harf ve hatchleme)
                    MessageBox.Show("Registration successfully created.");
                    Forms.Login login = new Login();
                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("\r\nPlease make sure that the fields marked with * are filled.");
                }
            }
            else
            {
                MessageBox.Show("Please accept the KVK terms.\r\n");
            }
            #endregion
        }
    }
}
