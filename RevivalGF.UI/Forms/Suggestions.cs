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

namespace RevivalGF.UI.Forms
{
    public partial class Suggestions : Form
    {
        public Suggestions()
        {
            InitializeComponent();
            mealService = new MealService();
            userService = new UserService();
        }
        UserService userService;
        MealService mealService;
        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
            Forms.MainForm main=new MainForm();
            main.Show();
            this.Hide();
        }
        private void Suggestions_Load_1(object sender, EventArgs e)
        {
            mealService.GetHaveAlternativeMeals(cbSearch);
            userService.UserTheme(Login.userNameControl, this, Properties.Resources.main, Properties.Resources.Dark_main);
        }
        private void cbSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var mealName = cbSearch.SelectedItem.ToString();
            mealService.GetAlternativeID(lblAlternative, mealName, rtbGluten, rtbGlutenFree);
        }
    }
}
