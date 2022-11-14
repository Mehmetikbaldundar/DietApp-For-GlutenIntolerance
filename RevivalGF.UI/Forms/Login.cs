using RevivalGF.DataAccess.Context;
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
        }

        RevivalGfDbContext db;

        private void Login_Load(object sender, EventArgs e)
        {
            db = new RevivalGfDbContext(); // Db connected
            tbPassword.UseSystemPasswordChar = true;  // for **** appearance
        }

        public static int id;
        public static string userName;

        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
            var userNameControl = db.Users.Where(x => x.UserName == tbUsername.Text.Trim()).FirstOrDefault();
            if (userNameControl != null)
            {
                userName = userNameControl.UserName;
                id = userNameControl.UserID;
                LoginCheck();
            }
            else
            {
                MessageBox.Show("Please enter a valid Username or Password.");
            }
            LoginCannotbeBlank();
        }

        private void lblRegister_DoubleClick(object sender, EventArgs e)
        {
            Forms.Register register = new Register();
            register.Show();
            this.Hide();

        }


        #region LoginMethods
        private void LoginCheck()
        {
            var userNameControl = db.Users.Where(x => x.UserName == tbUsername.Text.Trim()).FirstOrDefault();
            if (userNameControl != null)
            {
                if (userNameControl.Password == PasswordWithSha256(tbPassword.Text))
                {
                    MessageBox.Show("Login Succesful");
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password or Username Incorrect! \n Please check and try again");
                }
            }
            else
                MessageBox.Show("User Not Found !!");
        }
        private void LoginCannotbeBlank()
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            if (username == "" || password == "")
            {
                MessageBox.Show("Email and password fields cannot be empty.", "WARNING");
            }
        }
        #endregion
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        public string PasswordWithSha256(string text)
        {
            SHA256 sha256Encrypting = new SHA256CryptoServiceProvider();
            byte[] bytes = sha256Encrypting.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder builder = new StringBuilder();
            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }
            return builder.ToString();
        }
       
    }
}
