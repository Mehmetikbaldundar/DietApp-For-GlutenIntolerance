using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
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
        private void Register_Load(object sender, EventArgs e)
        {
            rdbMen.Checked = true;
        }

        RevivalGfDbContext db;
        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
            RegisterCheck();

            #region RegisterFormControl
            //if (cbAccepted.Checked)
            //{
            ////if (tbUsername.Text != "" && tbEmail.Text != "" && tbPassword.Text != "" && tbPassword.Text == tbRepeatPassword.Text && tbHeight.Text != "" && tbWeight.Text != "" &&   tbAge.Text != "" && cbActivityLevel.SelectedIndex != 0 && cbGoal.SelectedIndex != 0 && cbDisease.SelectedIndex != 0)
            //{
            ////cinsiyet kontrolü eklenecek
            ////parola kontrolü eklenecektir (min 8 karakter özel harf ve hatchleme)
            //MessageBox.Show("Registration successfully created.");
            //Forms.Login login = new Login();
            //login.Show();
            //this.Close();
            //}
            //else
            //{
            //MessageBox.Show("\r\nPlease make sure that the fields marked with * are filled.");
            //}
            //}
            //else
            //{
            //MessageBox.Show("Please accept the KVK terms.\r\n");
            //}
            #endregion
        }

        private void RegisterCheck()
        {
            Login login = new Login();

            if (tbPassword.Text != "" && tbRepeatPassword.Text != "")
            {
                if (GenaralControl() == true)
                {
                    if (UserNameExist(tbUsername.Text) == false)
                    {
                        User NewUser = new User()
                        {
                            UserName = tbUsername.Text,
                            Password = login.PasswordWithSha256(tbPassword.Text),
                        };
                        db.Users.Add(NewUser);
                        UserDetails NewUserDetails = new UserDetails()
                        {
                            Email = tbEmail.Text,
                            Name = tbFirstName.Text,
                            Surname = tbLastName.Text,
                            Gender = rdbWomen.Checked ? Gender.Woman : Gender.Man,
                            Height = Convert.ToDouble(tbHeight.Text),
                            Weight = Convert.ToDouble(tbWeight.Text),
                            BirthDate = dtpBirthDate.Value,
                            GlutenIntolerance = (GlutenIntolerance)cbDisease.SelectedIndex + 1
                        };
                        db.UserDetails.Add(NewUserDetails);
                        PhysicallyGoal physicallyGoal = new PhysicallyGoal()
                        {
                            ActivityStatus = (ActivityStatus)cbActivityLevel.SelectedIndex + 1,
                            TargetedDiet = (TargetedDiet)cbGoal.SelectedIndex + 1,
                        };
                        db.PhysicallyGoals.Add(physicallyGoal);
                        db.SaveChanges();

                        MessageBox.Show("Registation Successful");
                    }
                    else
                        MessageBox.Show("Username already exists. Please enter a different Username");
                }
                else
                {
                    if (UserNameCheck(tbUsername.Text) == false)
                        MessageBox.Show("Username cannot be empty !! ");

                    if (PasswordRules(tbPassword.Text) == false)
                        MessageBox.Show("Incorrect Password .. \n Please check to Password Rules");

                    if (PasswordCheck(tbPassword.Text, tbRepeatPassword.Text) == false)
                        MessageBox.Show("Passwords do not match");
                }
            }
            else if (tbUsername.Text == "" && tbPassword.Text == "" && tbRepeatPassword.Text == "")
            {
                if (UserNameCheck(tbUsername.Text) == false)
                    MessageBox.Show("Username cannot be empty !! ");

                if (PasswordCheck(tbPassword.Text, tbRepeatPassword.Text) == false)
                    MessageBox.Show("Password cannot be empty !! ");
            }
        }
        private bool UserNameCheck(string username)
        {
            if(username == null || username == "")
                return false;
            else
                return true;
        }
        private bool PasswordCheck(string password, string retryPassword)
        {
            if (password != retryPassword)
                return false;

            else
                return true;
        }
        public bool PasswordRules(string password)
        {
            int totalCharacter = 0, totalNumberChar = 0, totalUpperChar = 0, totalSpecialChar = 0;
            foreach (var item in password.ToCharArray())
            {
                if (char.IsUpper(item))
                    totalUpperChar++;
                if (char.IsNumber(item))
                    totalNumberChar++;
                if (!char.IsLetterOrDigit(item))
                    totalSpecialChar++;
                totalCharacter++;
            }
            if (totalCharacter < 8 || totalUpperChar < 1 || totalNumberChar < 1 || totalSpecialChar < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool GenaralControl()
        {
            if (PasswordRules(tbPassword.Text) && PasswordCheck(tbPassword.Text, tbRepeatPassword.Text) && UserNameCheck(tbUsername.Text))
                return true;

            else
                return false;
        }
        public bool UserNameExist(string userName)
        {
            var userNameControl = db.Users.Where(x => x.UserName == userName).FirstOrDefault();
            if (userNameControl != null)
            {
                return true;
            }
            else return false;
        }
    }
}
