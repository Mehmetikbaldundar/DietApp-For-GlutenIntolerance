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
            if (!cbAccepted.Checked)
            {
                MessageBox.Show("Please accept the terms and conditions.\r\n");
                return;
            }
            if (userService.PasswordMatch(tbPassword.Text, tbRepeatPassword.Text) == false)            
                throw new Exception("Passwords do not match");                      
            
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
                    DietCalorieControl = userService.DailyCalorieCalculator(NewUserDetails, physicallyGoal),
                };
                Water water = new Water();
                bool check = userService.RegisterCheck(NewUser, NewUserDetails, physicallyGoal, bodyAnalysis,water);
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
