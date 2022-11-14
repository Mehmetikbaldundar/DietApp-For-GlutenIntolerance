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
        public MainForm()
        {
            InitializeComponent();
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
            Forms.NutrientActivity nutact =new NutrientActivity();
            this.Hide();
            nutact.Show();
        }

        private void lblMedication_Click(object sender, EventArgs e)
        {
            Forms.Medication medication=new Medication();
            medication.Show();
            this.Hide();
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            Forms.Reports reports=new Reports();
            reports.Show();
            this.Hide();

        }

        private void lblRecipes_DoubleClick(object sender, EventArgs e)
        {
            Forms.Recipes recipes=new Recipes();
            recipes.Show();
            this.Hide();
        }

        private void lblSuggestions_DoubleClick(object sender, EventArgs e)
        {
            Forms.Suggestions suggestions=new Suggestions();
            suggestions.Show();
            this.Hide();
        }

        private void pbSettings_DoubleClick(object sender, EventArgs e)
        {
            Forms.Settings settings=new Settings();
            settings.Show();
            this.Hide();
        }
    }
}
