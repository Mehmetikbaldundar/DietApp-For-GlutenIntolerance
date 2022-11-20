using RevivalGF.Business.Services;
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
        private readonly MealReportsRepository _mealReportsRepository;
        ReportService reportService;
        UserService userService;
        public NutrientActivity()
        {
            db = new RevivalGfDbContext();
            _mealRepository= new MealRepository(db);
            _mealReportsRepository = new MealReportsRepository(db);
            userService = new UserService();
            reportService = new ReportService();

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
            var mealList = new List<Meal>();
            DailyCalorie();
            btnAdd.Enabled= false;
            NutrientCalculator();
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
        int selectedeatenmealID;
        private void dgwFoods_SelectionChanged(object sender, EventArgs e)
        {
            selectedmealID = Convert.ToInt32(dgwFoods.CurrentRow.Cells["MealID"].Value);
        }
        
        Meal eatenMeal;
        private void btnShow_Click(object sender, EventArgs e)
        {
            eatenMeal = _mealRepository.GetById(selectedmealID);
            decimal portion = Convert.ToDecimal(nudPortion.Value.ToString());
            lblMealName.Text = eatenMeal.MealName.ToString();
            lblFoodCalorie.Text = (eatenMeal.Calorie*portion).ToString("N");
            lblFoodCarbonhydrate.Text = (eatenMeal.Carbonhydrade*portion).ToString("N");
            lblFoodFat.Text = (eatenMeal.Fat*portion).ToString("N");
            lblFoodProtein.Text = (eatenMeal.Protein*portion).ToString("N");
            lblFoodGlutenRisk.Text = (eatenMeal.GlutenRisk).ToString();
            btnAdd.Enabled = true;
            int denme=(int)eatenMeal.GlutenRisk;
        }

        private static List<Meal> mealList=new List<Meal>();
        private static decimal totalCalorie;
        private static decimal totalProtein;
        private static decimal totalFat;
        private static decimal totalCarbohydrate;
        private static decimal totalGlutenRisk;

        private void btnAdd_Click(object sender, EventArgs e)
        {
           mealList.Add(eatenMeal);
            MealReport mealReport = new MealReport()
            {
                Portion = Convert.ToDecimal(nudPortion.Value.ToString()),
                Meals = mealList,
                TotalCalorie = Convert.ToDecimal(lblFoodCalorie.Text),
                TotalCarbohydrate = Convert.ToDecimal(lblFoodCarbonhydrate.Text),
                TotalFat = Convert.ToDecimal(lblFoodFat.Text),
                TotalProtein = Convert.ToDecimal(lblFoodProtein.Text),
                TotalGlutenRisk = (int)eatenMeal.GlutenRisk,
               UserID =Login.userNameControl.UserID,
               ReportDate=DateTime.Now,
           };
            _mealReportsRepository.Add(mealReport);
            dgwEatens.DataSource = db.MealReports.Where(x => x.UserID == Login.userNameControl.UserID && x.Status == Entites.Enums.Status.Active).Select(x => new
            { x.Portion,
                x.ReportDate,
                Meal = x.Meals.FirstOrDefault().MealName,
                x.MealReportID
            }).ToList();
            NutrientCalculator();
            DailyCalorie();
            btnAdd.Enabled = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var deletedmealrep = _mealReportsRepository.GetById(selectedeatenmealID);
                deletedmealrep.DeletedDate = DateTime.Now;
                _mealReportsRepository.Delete(deletedmealrep);
                dgwEatens.DataSource = db.MealReports.Where(x => x.UserID == Login.userNameControl.UserID && x.Status == Entites.Enums.Status.Active).Select(x => new
                {
                    x.Portion,
                    x.ReportDate,
                    Meal = x.Meals.FirstOrDefault().MealName,
                    x.MealReportID
                }).ToList();
                NutrientCalculator();
            }
            catch (Exception)
            {

                MessageBox.Show("There isn't any Meal");
            }
            DailyCalorie();

        }

        private void dgwEatens_SelectionChanged(object sender, EventArgs e)
        {
            selectedeatenmealID = Convert.ToInt32(dgwEatens.CurrentRow.Cells["MealReportID"].Value);
        }

        private void NutrientCalculator()
        {
            totalCalorie= 0;
            totalCarbohydrate = 0;
            totalFat = 0;
            totalProtein= 0;
            totalGlutenRisk = 0;
            foreach (var item in db.MealReports.Where(x => x.UserID == Login.userNameControl.UserID && x.Status == Entites.Enums.Status.Active))
            {
                totalCalorie= totalCalorie + item.TotalCalorie;
                totalCarbohydrate = totalCalorie + item.TotalCarbohydrate;
                totalFat = totalCalorie + item.TotalFat;
                totalProtein= totalCalorie + item.TotalProtein;
                totalGlutenRisk = Convert.ToDecimal(totalGlutenRisk + ((int)item.TotalGlutenRisk));

            }
            
            lblTotalCalorie.Text= totalCalorie.ToString() +" kcal";
            lblCarbohydrate.Text = totalCarbohydrate.ToString() + " gr";
            lblFat.Text = totalFat.ToString() + " gr";
            lblProtein.Text = totalProtein.ToString() + " gr";
            if (totalGlutenRisk>4)
            {
                lblGluten.BackColor = Color.Red;
                lblGluten.Text = totalGlutenRisk.ToString() + " !";
            }
            else
            {
                lblGluten.BackColor = Color.Transparent;
                lblGluten.Text = totalGlutenRisk.ToString() + " !";
            }
            
   
        }

        private void DailyCalorie()
        {
            decimal necessaryCalorie = userService.GetBodyAnalysis(Login.userNameControl).DietCalorieControl;
            decimal currentNecessaryCalories = reportService.CalorieUpdate(Activitytab.sportCalorie, necessaryCalorie); 
            lblDailyCalorie.Text = currentNecessaryCalories.ToString() + " kcal";           
        }
        private void lblActivityInput_Click(object sender, EventArgs e)
        {
            Forms.Activitytab activityform = new Forms.Activitytab();
            this.Hide();
            activityform.Show();
        }
    }
}
