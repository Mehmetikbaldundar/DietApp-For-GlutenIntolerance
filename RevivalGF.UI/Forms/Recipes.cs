using RevivalGF.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RevivalGF.UI.Forms
{
    public partial class Recipes : Form
    {

        public Recipes()
        {
            InitializeComponent();
            mealService = new MealService();
        }
        MealService mealService;
    

        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
           Forms.MainForm main=new MainForm();
            main.Show();
            this.Hide();
        }

        private void Recipes_Load(object sender, EventArgs e)
        {
            mealService.GetMealsForRecipe(cbRecipes);
        }

        private void cbRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mealName = cbRecipes.SelectedItem.ToString();
            mealService.GetRecipies(rtxtRecipies, mealName);
        }
    }
}
