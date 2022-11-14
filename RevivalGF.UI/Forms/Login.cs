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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
            Forms.MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void lblRegister_DoubleClick(object sender, EventArgs e)
        {
            Forms.Register register = new Register();
            register.Show();
            this.Hide();

        }

        #region MethodsforLoginScreen
        private void CheckLoginInfo()
        {
            string username = tbUsername.Text.Trim();
            string password =tbPassword.Text.Trim();
            if (username=="" || password=="")
            {
                MessageBox.Show("Email and password fields cannot be empty.", "WARNING");
            }
        }

        #endregion
    }
}
