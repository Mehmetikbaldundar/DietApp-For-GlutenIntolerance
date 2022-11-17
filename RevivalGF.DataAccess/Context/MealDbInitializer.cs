using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.DataAccess.Context
{
    public class MealDbInitializer : DropCreateDatabaseAlways<RevivalGfDbContext>
    {
        protected override void Seed(RevivalGfDbContext context)
        {
            IList<Meal> meals = new List<Meal>();

            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });
            meals.Add(new Meal() { MealName = "Test1", Recipe = null, Calorie = 100, Carbonhydrade = 100, Fat = 100, Protein = 100, Gram = 100, GlutenRisk = GlutenRisk.LowRisk, AlternativeFoodID = null, MealCategories = MealCategories.None });

            context.Meals.AddRange(meals);

            base.Seed(context);
        }

    }
}
