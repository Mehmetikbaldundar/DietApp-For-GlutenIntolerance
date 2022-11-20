using Microsoft.VisualBasic;
using RevivalGF.Business.Services;
using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.CodeDom.Compiler;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            userService = new UserService();
        }
        UserService userService;

        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
            Forms.MainForm main=new MainForm();
             main.Show();
             this.Hide();
        }
        private void FormLoadConfig()
        {
            var user = Login.userNameControl;
            var userDetails = userService.GetUserDetails(Login.userNameControl);
            var physicallyGoal = userService.GetPhysicallyGoal(Login.userNameControl);

            cbActivityLevel.DataSource = Enum.GetValues(typeof(ActivityStatus));
            cbGoal.DataSource = Enum.GetValues(typeof(TargetedDiet));

            tbFirstName.Text = userDetails.Name;
            tbLastName.Text = userDetails.Surname;
            Gender gender = userDetails.Gender;
            if (gender == Gender.Man)
                rdbMen.Checked = true;
            else
                rdbWomen.Checked = true;
            tbHeight.Text = userDetails.Height.ToString();
            tbWeight.Text = userDetails.Weight.ToString();
            dtpBirthDate.Value = userDetails.BirthDate;
            cbActivityLevel.SelectedIndex = (int)physicallyGoal.ActivityStatus - 1;
            cbGoal.SelectedIndex = (int)physicallyGoal.TargetedDiet - 1;
            tbUsername.Text = user.UserName;
            tbEmail.Text = userDetails.Email;
            tbPassword.Text = Login.userPassword;
            tbRepeatPasswprd.Text = Login.userPassword;

            tbPassword.UseSystemPasswordChar = true;
            tbRepeatPasswprd.UseSystemPasswordChar = true;

            tbFirstName.Enabled = false;
            tbLastName.Enabled = false;
            rdbMen.Enabled = false;
            rdbWomen.Enabled = false;
            tbHeight.Enabled = false;
            tbWeight.Enabled = false;
            dtpBirthDate.Enabled = false;
            cbActivityLevel.Enabled = false;
            cbGoal.Enabled = false;
            tbUsername.Enabled = false;
            tbEmail.Enabled = false;
            tbPassword.Enabled = false;
            tbRepeatPasswprd.Enabled = false;
            lblSaveChanges.Enabled = false;
            lblResetAccount.Enabled = false;
            lblDeleteAccount.Enabled = false;
        }
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            var changeLanguage = new ChangeLanguage();
            if (radioButton.Checked)
            {
                DialogResult yesNoQuestion = MessageBox.Show("Language has changed.. Application Will Restart", "Warning", MessageBoxButtons.YesNo);
                if(yesNoQuestion == DialogResult.Yes)
                {
                    if (rdbTr.Checked)
                        changeLanguage.UpdateConfig("language", "tr-TR");
                    else
                        changeLanguage.UpdateConfig("language", "en");

                    Application.Restart();
                }
                else
                    MessageBox.Show("language changing aborted");
            }
        }
        private void lblSaveChanges_Click_1(object sender, EventArgs e)
        {
            var user = Login.userNameControl;
            var userDetails = userService.GetUserDetails(Login.userNameControl);
            var physicallyGoal = userService.GetPhysicallyGoal(Login.userNameControl);
            var bodyAnalysis = userService.GetBodyAnalysis(Login.userNameControl);
            if (tbPassword.Text != tbRepeatPasswprd.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            try
            {
                user.UserName = tbUsername.Text;
                user.Password = tbPassword.Text;

                userDetails.Email = tbEmail.Text;
                userDetails.Name = tbFirstName.Text.Trim();
                userDetails.Surname = tbLastName.Text.Trim();
                userDetails.Gender = rdbWomen.Checked ? Gender.Woman : Gender.Man;
                userDetails.Height = Convert.ToDouble(tbHeight.Text);
                userDetails.Weight = Convert.ToDouble(tbWeight.Text);
                userDetails.BirthDate = Convert.ToDateTime(dtpBirthDate.Value);

                physicallyGoal.ActivityStatus = (ActivityStatus)cbActivityLevel.SelectedIndex + 1;
                physicallyGoal.TargetedDiet = (TargetedDiet)cbGoal.SelectedIndex + 1;

                bodyAnalysis.BodyMassIndex = userService.BodyMassIndexResult(userDetails);
                bodyAnalysis.DietCalorieControl = userService.DailyCalorieCalculator(userDetails, physicallyGoal);

                bool check = userService.UpdateCheck(user, userDetails, physicallyGoal, bodyAnalysis, tbEmail.Text, tbUsername.Text);
                if (check)
                    chkEnable.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Settings_Load_1(object sender, EventArgs e)
        {
            FormLoadConfig();
            rdbTr.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            // tdbEng.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
        }
        private void tbHeight_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tbWeight_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void chkEnable_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkEnable.Checked == true)
            {
                SecurityService security = new SecurityService();
                string verificationControl = Interaction.InputBox("Please Write Password.", "Verification", "", 900, 400);
                bool result = userService.PasswordCheck(Login.userNameControl, security, verificationControl);
                if (result)
                {
                    tbFirstName.Enabled = true;
                    tbLastName.Enabled = true;
                    rdbMen.Enabled = true;
                    rdbWomen.Enabled = true;
                    tbHeight.Enabled = true;
                    tbWeight.Enabled = true;
                    dtpBirthDate.Enabled = true;
                    cbActivityLevel.Enabled = true;
                    cbGoal.Enabled = true;
                    tbUsername.Enabled = true;
                    tbEmail.Enabled = true;
                    tbPassword.Enabled = true;
                    tbRepeatPasswprd.Enabled = true;
                    lblSaveChanges.Enabled = true;
                    lblResetAccount.Enabled = true;
                    lblDeleteAccount.Enabled = true;
                }
                else
                    chkEnable.Checked = false;
            }
            else
            {
                chkEnable.Checked = false;
                FormLoadConfig();
            }
        }
        private void tbPassword_MouseClick_1(object sender, MouseEventArgs e)
        {
            tbPassword.Clear();
            tbPassword.UseSystemPasswordChar = true;
        }
        private void tbRepeatPasswprd_MouseClick_1(object sender, MouseEventArgs e)
        {
            tbRepeatPasswprd.Clear();
            tbRepeatPasswprd.UseSystemPasswordChar = true;
        }
        private void rdbDark_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        private void rdbLight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
