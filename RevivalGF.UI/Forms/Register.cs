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
using RevivalGF.DataAccess.Concrete;
using RevivalGF.Business.Services;

namespace RevivalGF.UI.Forms
{
    public partial class Register : Form
    {    

        public Register()
        {          

            InitializeComponent();
            userService = new UserService();
        }
        UserService userService;
        private void Register_Load(object sender, EventArgs e)
        {
            rdbMen.Checked = true;
            cbActivityLevel.DataSource = Enum.GetValues(typeof(ActivityStatus));
            cbGoal.DataSource = Enum.GetValues(typeof(TargetedDiet));
            cbDisease.DataSource = Enum.GetValues(typeof(GlutenIntolerance));
        }

        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
                            if (VerificationCodeSend(tbEmail.Text) == false)
                                MessageBox.Show("Verification Code is not Correct !!");
                            else
                            {
                                User NewUser = new User()
                                {
                                    UserName = tbUsername.Text,
                                    Password = login.PasswordWithSha256(tbPassword.Text),
                                };
                                _userRepository.Add(NewUser);                                
                                UserDetails NewUserDetails = new UserDetails()
                                {
                                    DetailsID = NewUser.UserID,
                                    Email = tbEmail.Text,
                                    Name = tbFirstName.Text.Trim(),
                                    Surname = tbLastName.Text.Trim(),
                                    Gender = rdbWomen.Checked ? Gender.Woman : Gender.Man,
                                    Height = Convert.ToDouble(tbHeight.Text),
                                    Weight = Convert.ToDouble(tbWeight.Text),
                                    BirthDate = Convert.ToDateTime(dtpBirthDate.Value),
                                    GlutenIntolerance = (GlutenIntolerance)cbDisease.SelectedIndex + 1
                                };
                                _detailsRepository.Add(NewUserDetails);

                                PhysicallyGoal physicallyGoal = new PhysicallyGoal()
                                {
                                    GoalID = NewUser.UserID,
                                    ActivityStatus = (ActivityStatus)cbActivityLevel.SelectedIndex + 1,
                                    TargetedDiet = (TargetedDiet)cbGoal.SelectedIndex + 1,
                                };
                                _goalsRepository.Add(physicallyGoal);
      
                                BodyAnalysis bodyAnalysis = new BodyAnalysis()
                                {
                                    AnalysisID = _userRepository.GetById(NewUser.UserID).UserID,
                                    BodyMassIndex = (BodyMassIndex)BodyMassIndexResult(),
                                    DietCalorieControl= DailyCalorieCalculator(),
                                };
                                _bodyAnalysisRepository.Add(bodyAnalysis);

                                MessageBox.Show("Registation Successful");
                            }

                        }
                        else
                            MessageBox.Show("Username or Email already exists. Please enter a different Username or Email !! ");
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
=======
            if (!cbAccepted.Checked)
>>>>>>> f00d599bf8ce3f6b16aecc4dab56cb91d6f27b3f
            {
                MessageBox.Show("Please accept the terms and conditions.\r\n");
                return;
            }
            try
            {
                User NewUser = new User()
                {
                    UserName = tbUsername.Text,
                    Password = tbPassword.Text,
                };                
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
                PhysicallyGoal physicallyGoal = new PhysicallyGoal()
                {                    
                    ActivityStatus = (ActivityStatus)cbActivityLevel.SelectedIndex + 1,
                    TargetedDiet = (TargetedDiet)cbGoal.SelectedIndex + 1,
                };
                BodyAnalysis bodyAnalysis = new BodyAnalysis()
                {                   
                    BodyMassIndex = userService.BodyMassIndexResult(NewUserDetails),
                    DietCalorieControl = userService.DailyCalorieCalculator(NewUserDetails,physicallyGoal),
                };
                bool check = userService.RegisterCheck(NewUser,tbRepeatPassword.Text,NewUserDetails,physicallyGoal,bodyAnalysis);
                if (check)
                {
                    Login login = new Login();
                    this.Hide();                   
                    login.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
