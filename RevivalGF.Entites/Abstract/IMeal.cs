using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Abstract
{
    public interface IMeal
    {
        int MealID { get; set; }
        string MealName { get; set; }
        string Recipe { get; set; }
        decimal Calorie { get; set; }
        decimal Carbonhydrade { get; set; }
        decimal Fat { get; set; }
        decimal Protein { get; set; }
        decimal Gram { get; set; }
        GlutenRisk GlutenRisk { get; set; }
        int? AlternativeFoodID { get; set; }        
        int MealReportID { get; set; }
        MealReport MealReport { get; set; }   
        MealCategories MealCategories { get; set; }
    }
}
