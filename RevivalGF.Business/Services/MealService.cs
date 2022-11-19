using RevivalGF.DataAccess.Concrete;
using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevivalGF.Business.Services
{

    public class MealService
    {
        private readonly RevivalGfDbContext db;
        private readonly MealRepository _mealRepository;
        private static List<Meal> meals;
        public MealService()
        {
            db = new RevivalGfDbContext();
            _mealRepository = new MealRepository(db);
            meals = _mealRepository.GetAll();
        }

        public void GetMealsForRecipe(ComboBox comboBox)
        {
            comboBox.DataSource = meals.Where(x => x.Recipe != null).Select(x => x.MealName).ToList();
        }
        public void GetRecipies(RichTextBox richTextBox, string mealName)
        {
            richTextBox.Text = meals.Where(x => x.MealName == mealName).Select(x => x.Recipe).FirstOrDefault();
        }
        public void GetHaveAlternativeMeals(ComboBox comboBox)
        {
            comboBox.DataSource = meals.Where(x => x.AlternativeFoodID != null).OrderBy(x=>x.MealName).Select(x => x.MealName).ToList();
        }
        public void GetAlternativeID(Label label, string mealName,RichTextBox rtbGluten, RichTextBox rtbGlutenFree)
        {
            var alternativeID = meals.Where(x => x.MealName == mealName).Select(x => x.AlternativeFoodID).FirstOrDefault();
            label.Text = meals.Where(x => x.MealID == alternativeID).Select(x => x.MealName).FirstOrDefault();
            rtbGluten.Text = meals.Where(x => x.MealName == mealName)
                .Select(x => new
                {
                    GlutenRisk = x.GlutenRisk + "\n",
                    Calorie = x.Calorie + "\n",
                    Protein = x.Protein + "\n",
                    Carbonhydrade = x.Carbonhydrade + "\n",
                    Fat = x.Fat + "\n",
                    Gram = x.Gram + "\n",
                }).FirstOrDefault().ToString();
            rtbGlutenFree.Text = meals.Where(x => x.MealID == alternativeID)
                .Select(x => new
                {
                    GlutenRisk = x.GlutenRisk + "\n",
                    Calorie = x.Calorie + "\n",
                    Protein = x.Protein + "\n",
                    Carbonhydrade = x.Carbonhydrade + "\n",
                    Fat = x.Fat + "\n",
                    Gram = x.Gram + "\n",
                }).FirstOrDefault().ToString();
        }        
       
    }
}
