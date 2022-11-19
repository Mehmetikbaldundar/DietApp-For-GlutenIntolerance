using Microsoft.VisualBasic.ApplicationServices;
using RevivalGF.Business.Services;
using RevivalGF.DataAccess.Concrete;
using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Abstract;
using RevivalGF.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RevivalGF.UI.Forms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            userService = new UserService();
            waterService=new WaterService();
            InitializeComponent();
        }
        UserService userService;
        WaterService waterService;
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            var userNameControl = Login.userNameControl;
            var userdetails = waterService.GetUserDetails(userNameControl);
            
            if (userNameControl.Tutorial==true)
            {
                gbPlummy1.Visible = true;
                waterService.PlummyOffline(userNameControl);
            }
            else
            {
                gbPlummy1.Visible = false;
            }

            gbPlummy2.Visible = false;
            gbPlummy3.Visible = false;
            gbPlummy4.Visible = false;
            gbPlummy5v2.Visible = false;
            gbPlummy6.Visible = false;

            lblUsername.Text = userNameControl.UserName;          
            lblAge.Text = (DateTime.Now.Year - userdetails.BirthDate.Year).ToString();        
            lblHeight.Text = userdetails.Height.ToString() + " " + "cm";
            lblWeight.Text = userdetails.Weight.ToString() + " " + "kg";
            lblIdealWeight.Text = Math.Round(IdealWeight(userdetails)).ToString() + " " + "kg";
            lblDisease.Text = userdetails.GlutenIntolerance.ToString();

            if ((int)userdetails.Gender==1)
            {
                pbAvatar.Image = Properties.Resources.avatar_men;
            }
            else
            {
                pbAvatar.Image = Properties.Resources.avatar_women;
            }

            int glasscount = waterService.WaterCount(userNameControl);
            int waterml = glasscount * 250;
            lblWaterInfo.Text = glasscount.ToString() + " glass = " + waterml + " mL";
            ProgressBar(glasscount);
        }
        #region PlummySection
        private void pbPlummy1Next_DoubleClick(object sender, EventArgs e)
        {
            gbPlummy1.Visible = false;
            gbPlummy2.Visible = true;
        }

        private void pbPlummy2Next_DoubleClick(object sender, EventArgs e)
        {
            gbPlummy2.Visible = false;
            gbPlummy3.Visible = true;
        }

        private void pbPlummy3Next_DoubleClick(object sender, EventArgs e)
        {
            gbPlummy3.Visible = false;
            gbPlummy4.Visible = true;
        }

        private void pbPlummy4Next_DoubleClick(object sender, EventArgs e)
        {
            gbPlummy4.Visible = false;
            gbPlummy5v2.Visible = true;
        }

        private void pbPlummyNext5_DoubleClick(object sender, EventArgs e)
        {
            gbPlummy5v2.Visible = false;
            gbPlummy6.Visible = true;
        }

        private void pbPlummyNext6_DoubleClick(object sender, EventArgs e)
        {
            gbPlummy6.Visible = false;
            
        }
        #endregion

 
        private void lblNutrientandActivity_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Forms.NutrientActivity nutact = new NutrientActivity();            
            this.Hide();
            nutact.Show();           
=======
            Forms.NutrientActivity nutact = new NutrientActivity();
            this.Hide();
            nutact.Show();
>>>>>>> master
        }

        private void lblMedication_Click(object sender, EventArgs e)
        {
            Forms.Medication medication = new Medication();
            medication.Show();
            this.Hide();
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            Forms.Reports reports = new Reports();
            reports.Show();
            this.Hide();

        }

        private void lblRecipes_DoubleClick(object sender, EventArgs e)
        {
            Forms.Recipes recipes = new Recipes();
            recipes.Show();
            this.Hide();
        }

        private void lblSuggestions_DoubleClick(object sender, EventArgs e)
        {
            Forms.Suggestions suggestions = new Suggestions();
            suggestions.Show();
            this.Hide();
        }

        private void pbSettings_DoubleClick(object sender, EventArgs e)
        {
            Forms.Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        #region IdealWeightCalcute
        private double IdealWeight(UserDetails userdetails)
        {
            double weight = userdetails.Weight;
            double height = userdetails.Height;
            int gender = (int)userdetails.Gender;
            double idealweight = 0;
            if (gender == 1)
            {
                idealweight = 50 + 2.3 * ((height / 2.54) - 60);
                return idealweight;
            }
            else
            {
                idealweight = 45.5 + 2.3 * ((height / 2.54) - 60);
                return idealweight;
            }
        }
        #endregion
        private void pbMinusWater_Click_1(object sender, EventArgs e)
        {
            int glasscount;
            glasscount = waterService.DecreaseWater(Login.userNameControl);
            int waterml = glasscount * 250;
            lblWaterInfo.Text = glasscount.ToString() + " glass = " + waterml + " mL";
            ProgressBar(glasscount);
        }
        private void pbAddWater_Click_1(object sender, EventArgs e)
        {
           
            int glasscount;
            glasscount = waterService.IncreaseWater(Login.userNameControl);
            int waterml = glasscount * 250;
            lblWaterInfo.Text = glasscount.ToString() +" glass = " + waterml + " mL";
            ProgressBar(glasscount);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void ProgressBar(int glasscount)
        {
            ProgressBarWater.Minimum = 0;
            ProgressBarWater.Maximum = 10;
            ProgressBarWater.Step = 1;
            if (glasscount<10)
            {
                ProgressBarWater.Value = glasscount;
                pbTick.Visible = false;
            }
            else
            {
                ProgressBarWater.Value = 10;
                pbTick.Visible = true;
            }
        }
    }
}
