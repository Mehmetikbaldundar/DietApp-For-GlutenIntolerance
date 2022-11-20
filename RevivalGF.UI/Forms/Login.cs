using Microsoft.VisualBasic.ApplicationServices;
using RevivalGF.Business.Services;
using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            userService = new UserService();
        }
        UserService userService;                
        
        private void Login_Load(object sender, EventArgs e)
        {            
            tbPassword.UseSystemPasswordChar = true;  // for **** appearance            
        }

        public static Entites.Concrete.User userNameControl;
        public static string userPassword;
        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
            userNameControl = userService.UsernameControl(tbUsername.Text);

            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Email and password fields cannot be empty. !!");
                return;
            }              

            bool check = userService.LoginCheck(tbUsername.Text, tbPassword.Text);
            if (check)
            {
                MessageBox.Show("Login Succesful");
                userPassword = tbPassword.Text;
                MainForm main = new MainForm();
                main.Show();
                Hide();
            }           
        }

        private void lblRegister_DoubleClick(object sender, EventArgs e)
        {
            Forms.Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            pbNext.Cursor = Cursors.WaitCursor;
        }        
    }
}
