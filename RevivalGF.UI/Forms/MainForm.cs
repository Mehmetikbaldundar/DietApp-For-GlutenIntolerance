using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Concrete;
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
    public partial class MainForm : Form
    {
            RevivalGfDbContext db = new RevivalGfDbContext();
            private readonly int UserID;
            public MainForm()
            {
                InitializeComponent();
                db = new RevivalGfDbContext();
            }

            private void MainForm_Load(object sender, EventArgs e)
            {
                /*if (true)
             {
                 gbPlummy1.Visible = false;
             }
             else
             {
                 gbPlummy1.Visible=true;
             }   plummy var yok koşunu yaz*/
                gbPlummy2.Visible = false;
                gbPlummy3.Visible = false;
                gbPlummy4.Visible = false;
                gbPlummy5v2.Visible = false;
                gbPlummy6.Visible = false;
                lblUsername.Text = user.UserName;
                lblAge.Text = (DateTime.Now.Year - user.UserDetails.BirthDate.Year).ToString();
                lblHeight.Text = user.UserDetails.Height.ToString() + " " + "cm";
                lblWeight.Text = user.UserDetails.Weight.ToString() + " " + "kg";
                lblIdealWeight.Text = IdealWeight().ToString() + " " + "kg";
                lblDisease.Text = user.UserDetails.GlutenIntolerance.ToString();
                // pbAvatar.Image=Image.FromFile   -->Bu kısım için resources kısmına en azından kadın erkek avatarlarını atmalıyız.

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

            User user = new User();
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
            private double IdealWeight()
            {
                //Entites.Enums.Gender gender = user.UserDetails.Gender;
                double weight = user.UserDetails.Weight;
                double height = user.UserDetails.Height;
                int gender = (int)user.UserDetails.Gender;
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

            private void pbAddWater_Click(object sender, EventArgs e)
            {
                
            }

            private void pbMinusWater_Click(object sender, EventArgs e)
            {
                /* if (user.Waters!=null)
                 {
                     user.Waters.WaterCount++;
                 }*/

                ///water glassın countuyla ml ve bardak yazılacak  ondan sonra progress bara işlenecek water null ise eksiye basılmayacak, değilse azaltılabilecek ,saveandhange yapılacak
            }
        
    }
}
