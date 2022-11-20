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
            reportService= new ReportService();
            InitializeComponent();
        }
        UserService userService;
        WaterService waterService;
        ReportService reportService;

        public static decimal currentNecessaryCalories; //The required calories, which change with the sports and the food that the user eats.
        private void MainForm_Load(object sender, EventArgs e)
        {
            var userNameControl = Login.userNameControl;
            var userdetails = waterService.GetUserDetails(userNameControl);
            userService.UserTheme(userNameControl, this, Properties.Resources.main, Properties.Resources.Dark_main);
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
            lblIdealWeight.Text = Math.Round(reportService.IdealWeight(userdetails)).ToString() + " " + "kg";
            lblDisease.Text = userdetails.GlutenIntolerance.ToString();

            lblGluten.Text = reportService.GlutenQuery(userNameControl);
            lblMedicationAttention.Text = reportService.MedicineQuery(userNameControl);

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
            decimal necessaryCalorie = userService.GetBodyAnalysis(userNameControl).DietCalorieControl;
            currentNecessaryCalories = reportService.CalorieUpdate(Activitytab.sportCalorie, necessaryCalorie);
            CircularProgressbar();
        }

        //The events here will only work when the Plummy feature is active.
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

        #region TransitionEventsBetweenForms
        private void lblNutrientandActivity_Click(object sender, EventArgs e)
        {
            NutrientActivity nutact = new NutrientActivity();
            Hide();
            nutact.Show();
        }
        private void lblMedication_Click(object sender, EventArgs e)
        {
            Medication medication = new Medication();
            medication.Show();
            Hide();
        }
        private void lblReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            Hide();
        }
        private void lblRecipes_DoubleClick(object sender, EventArgs e)
        {
            Recipes recipes = new Recipes();
            recipes.Show();
            Hide();
        }

        private void lblSuggestions_DoubleClick(object sender, EventArgs e)
        {
            Suggestions suggestions = new Suggestions();
            suggestions.Show();
            Hide();
        }

        private void pbSettings_DoubleClick(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            Hide();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        #region MethodsUsedinThisForm
        //This method is written for the progress of the water progress bar.
        public void ProgressBar(int glasscount) 
        {
            ProgressBarWater.Minimum = 0;
            ProgressBarWater.Maximum = 10;
            ProgressBarWater.Step = 1;
            if (glasscount < 10)
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
        //This method is written for the progress of the calorie circular progress bar.
        public void CircularProgressbar()
        {
            int percentOfTakenCalorie = reportService.CircularBarCalorie(currentNecessaryCalories, Login.userNameControl);
            if (percentOfTakenCalorie <= 100)
            {
                circularProgressBarCalorie.Value = percentOfTakenCalorie;
                circularProgressBarCalorie.Text = percentOfTakenCalorie.ToString() + " %";
            }
            else
            {
                circularProgressBarCalorie.Value = 100;
                circularProgressBarCalorie.Text = "100 %";
            }
        }
        #endregion
    }
}
