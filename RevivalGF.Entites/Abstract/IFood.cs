using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Abstract
{
    public interface IFood
    {
        int FoodID { get; set; }
        string FoodName { get; set; }
        MeauserementUnit MeauserementUnit { get; set; }
        float Gram { get; set; }
        float Calorie { get; set; }
        float Carbonhydrade { get; set; }
        float Fat { get; set; }
        float Protein { get; set; }
        GlutenRisk GlutenRisk { get; set; }
        int? AlternativeFoodID { get; set; }
        int MealID { get; set; }
        Meal Meal { get; set; }
    }
}
