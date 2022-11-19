using RevivalGF.DataAccess.Concrete;
using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace RevivalGF.UI.Forms
{
    public partial class NutrientActivity : Form
    {
        private readonly RevivalGfDbContext db;
        private readonly MealRepository _mealRepository;
        public NutrientActivity()
        {
            db = new RevivalGfDbContext();
            _mealRepository= new MealRepository(db);
            InitializeComponent();
        }
        private void pbNext_DoubleClick(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
        private void NutrientActivity_Load(object sender, EventArgs e)
        {
            cbCategories.DataSource = Enum.GetValues(typeof(MealCategories));
            cbActivity.DataSource = Enum.GetValues(typeof(Activities));
            var mealList = new List<Meal>();
        }
        int mealID;
        
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListMeal(); 
        }
        private void cbGluten_CheckedChanged(object sender, EventArgs e)
        {
           ListMeal();
        }

        private void ListMeal()
        {
            mealID = (int)cbCategories.SelectedValue;
            MealCategories selectedCategory = (MealCategories)mealID;
            if (cbGluten.Checked)
            {
                dgwFoods.DataSource = db.Meals.Where(x => (x.MealCategories == selectedCategory) && x.GlutenRisk == 0).Select(x => new
                {
                    Name = x.MealName,
                    Calorie = x.Calorie,
                    Gram = x.Gram,
                    ServiceType = x.ServiceType,
                    Carbonhydrade = x.Carbonhydrade,
                    Fat = x.Fat,
                    Protein = x.Protein,
                    GlutenRisk = x.GlutenRisk,
                    MealID = x.MealID,

                }).ToList();
            }
            else
            {
                dgwFoods.DataSource = db.Meals.Where(x => (x.MealCategories == selectedCategory)).Select(x => new
                {
                    Name = x.MealName,
                    Calorie = x.Calorie,
                    Gram = x.Gram,
                    ServiceType = x.ServiceType,
                    Carbonhydrade = x.Carbonhydrade,
                    Fat = x.Fat,
                    Protein = x.Protein,
                    GlutenRisk = x.GlutenRisk,
                    MealID = x.MealID,

                }).ToList();
            }
        }
        private void ListMealbyText()
        {
            mealID = (int)cbCategories.SelectedValue;
            MealCategories selectedCategory = (MealCategories)mealID;
            if (cbGluten.Checked)
            {
                dgwFoods.DataSource = db.Meals.Where(x => x.MealName.Contains(tbSearch.Text) && (x.MealCategories == selectedCategory) && x.GlutenRisk == 0).Select(x => new
                {
                    Name = x.MealName,
                    Calorie = x.Calorie,
                    Gram = x.Gram,
                    ServiceType = x.ServiceType,
                    Carbonhydrade = x.Carbonhydrade,
                    Fat = x.Fat,
                    Protein = x.Protein,
                    GlutenRisk = x.GlutenRisk,
                    MealID= x.MealID,

                }).ToList();
            }
            else
            {
                dgwFoods.DataSource = db.Meals.Where(x => x.MealName.Contains(tbSearch.Text) && (x.MealCategories == selectedCategory)).Select(x => new
                {
                    Name = x.MealName,
                    Calorie = x.Calorie,
                    Gram = x.Gram,
                    ServiceType = x.ServiceType,
                    Carbonhydrade = x.Carbonhydrade,
                    Fat = x.Fat,
                    Protein = x.Protein,
                    GlutenRisk = x.GlutenRisk,
                    MealID = x.MealID,

                }).ToList();
            }

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text!="")
            {
                ListMealbyText();
            }
            else
            {
                ListMeal();
            }
        }
        private void NutrientActivity_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }
        int selectedmealID;
        private void dgwFoods_SelectionChanged(object sender, EventArgs e)
        {
            selectedmealID = Convert.ToInt32(dgwFoods.CurrentRow.Cells["MealID"].Value);
        }
        decimal totalcalorie=0;
        private void btnShow_Click(object sender, EventArgs e)
        {
            var eatenMeal = _mealRepository.GetById(selectedmealID);
            mealList.Add(eatenMeal);
            lbFoods.DataSource= mealList.Select(x=>x.MealName).ToList();
           

           decimal portion=Convert.ToDecimal(nudPortion.Value.ToString());

            /*foreach (var item in mealList.Select(x => x.Calorie))
            { 
                totalcalorie =  (portion * item);
            }*/
            totalcalorie = (mealList.Select(x => x.Calorie)).Last() * portion + totalcalorie;
          
           lblFoodCalorie.Text = totalcalorie.ToString("N")+" kcal";
          //lblFoodCalorie.Text=(eatenMeal.Calorie*portion).ToString("N")+" kcal";*/

          
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deneme=lbFoods.SelectedItem;
            lbFoods.Items.Remove(deneme);
            lblFoodCalorie.Text = "0 kcal";    
        }

        private static List<Meal> mealList=new List<Meal>();
        
    }
}
