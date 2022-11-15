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
using System.Net.Mail;
using System.Net;
using Microsoft.VisualBasic;

namespace RevivalGF.UI.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            db = new RevivalGfDbContext();
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            rdbMen.Checked = true;
            cbActivityLevel.DataSource = Enum.GetValues(typeof(ActivityStatus));
            cbGoal.DataSource = Enum.GetValues(typeof(TargetedDiet));
            cbDisease.DataSource = Enum.GetValues(typeof(GlutenIntolerance));

        }

        RevivalGfDbContext db;
        private void pbNext_DoubleClick(object sender, EventArgs e)
        {            
            RegisterCheck();
        }

        private void RegisterCheck()
        {
            Login login = new Login();
            if (cbAccepted.Checked)
            {
                if (tbPassword.Text != "" && tbRepeatPassword.Text != "")
                {
                    if (GenaralControl() == true)
                    {
                        if (UserNameExist(tbUsername.Text) == false && MailExist(tbEmail.Text) == false)
                        {
                            if(VerificationCodeSend(tbEmail.Text) == false)
                                MessageBox.Show("Verification Code is not Correct !!");
                            else
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
                                    Name = tbFirstName.Text.Trim(),
                                    Surname = tbLastName.Text.Trim(),
                                    Gender = rdbWomen.Checked ? Gender.Woman : Gender.Man,
                                    Height = Convert.ToDouble(tbHeight.Text),
                                    Weight = Convert.ToDouble(tbWeight.Text),
                                    BirthDate = Convert.ToDateTime(dtpBirthDate.Value),
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

                        }
                        else
                            MessageBox.Show("Username or Email already exists. Please enter a different Username");
                    }
                    else
                    {
                        if (UserNameCheck(tbUsername.Text) == false)
                            MessageBox.Show("Username cannot be empty !! ");

                        if (MailCheck(tbEmail.Text) == false)
                            MessageBox.Show("Email Address is not correct");

                        if (PasswordRules(tbPassword.Text) == false)
                            MessageBox.Show("Incorrect Password .. \n Please check to Password Rules");

                        if (PasswordCheck(tbPassword.Text, tbRepeatPassword.Text) == false)
                            MessageBox.Show("Passwords do not match");
                    }
                }
                else if (tbUsername.Text == "" && tbPassword.Text == "" && tbRepeatPassword.Text == "" && tbEmail.Text == "")
                {
                    if (UserNameCheck(tbUsername.Text) == false)
                        MessageBox.Show("Username cannot be empty !! ");

                    if (MailCheck(tbEmail.Text) == false)
                        MessageBox.Show("Email Address cannot be empty !! ");

                    if (PasswordCheck(tbPassword.Text, tbRepeatPassword.Text) == false)
                        MessageBox.Show("Password cannot be empty !! ");
                }
            }
            else
            {
                MessageBox.Show("Please accept the terms and conditions.\r\n");
            }

        }
        private bool UserNameCheck(string username)
        {
            if (username == null || username == "")
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
            if (PasswordRules(tbPassword.Text) && PasswordCheck(tbPassword.Text, tbRepeatPassword.Text) && UserNameCheck(tbUsername.Text) && MailCheck(tbEmail.Text))
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
        public bool MailExist(string email)
        {
            var emailControl = db.UserDetails.Where(x => x.Email == email).FirstOrDefault();
            if (emailControl != null)
            {
                return true;
            }
            else return false;
        }
        public bool MailCheck(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static string verificationCode = "";
        public bool VerificationCodeSend(string mail)
        {
            bool result = false;

            string appMail = "revivalgfapp@outlook.com";
            string sifre = "Revivalgf4*";

            Random rnd = new Random();
            string Keys = "0123456789";
            verificationCode = "";
            for (int i = 0; i < 6; i++)
            {
                verificationCode += Keys[rnd.Next(Keys.Length)];
            }
            try
            {
                MailMessage message = new MailMessage(appMail, mail, "Verification Code", "REVIVAL GF Application Registiration Code: '" + verificationCode + "'\n\nRevivalGF Team");
                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential(appMail, sifre);
                smtp.Send(message);
                string verificationControl = Interaction.InputBox("Please Write Verification Code.", "Verification", "", 0, 0);
                if (verificationControl == verificationCode)
                    result = true;
                else
                {
                    result = false;                    
                }              
            }
            catch
            {
                MessageBox.Show("Mail Address is not correct");
            }
            return result;
        }


        #region *remove/add
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (tbUsername.Text != "")
            {
                label15.Visible = false;
            }
            else
            {
                label15.Visible = true;
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbEmail.Text != "")
            {
                label17.Visible = false;
            }
            else
            {
                label17.Visible = true;
            }
        }
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

            if (tbPassword.Text != "")
            {
                label16.Visible = false;
            }
            else
            {
                label16.Visible = true;
            }
        }
        private void tbRepeatPassword_TextChanged(object sender, EventArgs e)
        {

            if (tbRepeatPassword.Text != "")
            {
                label18.Visible = false;
            }
            else
            {
                label18.Visible = true;
            }
        }
        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "")
            {
                label10.Visible = false;
            }
            else
            {
                label10.Visible = true;
            }
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "")
            {
                label7.Visible = false;
            }
            else
            {
                label7.Visible = true;
            }
        }
        private void tbHeight_TextChanged(object sender, EventArgs e)
        {
            if (tbHeight.Text != "")
            {
                label20.Visible = false;
            }
            else
            {
                label20.Visible = true;
            }
        }
        private void tbWeight_TextChanged(object sender, EventArgs e)
        {
            if (tbHeight.Text != "")
            {
                label22.Visible = false;
            }
            else
            {
                label22.Visible = true;
            }
        }
        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            label28.Visible = false;
        }

        private void cbActivityLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            label19.Visible = false;
        }

        private void cbGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            label21.Visible = false;
        }

        private void cbDisease_SelectedIndexChanged(object sender, EventArgs e)
        {
            label30.Visible = false;
        }

        #endregion
    }
}
