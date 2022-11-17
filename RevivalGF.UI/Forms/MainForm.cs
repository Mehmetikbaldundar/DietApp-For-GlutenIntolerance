using RevivalGF.Business.Services;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RevivalGF.UI.Forms
{
    public partial class MainForm : Form
    {      
        
        public MainForm()
        {

            userService = new UserService();
            InitializeComponent();
        }
        UserService userService;
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            var userNameControl = Login.userNameControl;
            var userdetails = userService.GetUserDetails(userNameControl);           

            if (userNameControl.Tutorial==true)
            {
                gbPlummy1.Visible = true;
                userService.PlummyOffline(userNameControl);
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
            Forms.NutrientActivity nutact = new NutrientActivity();
            this.Hide();
            nutact.Show();
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
            var water = userService.DecreaseWater(Login.userNameControl);
            lblWaterInfo.Text = water.WaterCount.ToString();            
        }
        private void pbAddWater_Click_1(object sender, EventArgs e)
        {
            var water = userService.IncreaseWater(Login.userNameControl);
            lblWaterInfo.Text = water.WaterCount.ToString(); 
        }
    }
}
