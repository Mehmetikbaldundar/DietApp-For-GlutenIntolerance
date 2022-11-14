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
        float Calorie { get; set; }
        float Carbonhydrade { get; set; }
        float Fat { get; set; }
        float Protein { get; set; }
        int GlutenRisk { get; set; }
        List<Food> Foods { get; set; }
        int MealReportID { get; set; }
        MealReport MealReport { get; set; }
    }
}
