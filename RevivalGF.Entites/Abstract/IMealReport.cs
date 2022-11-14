using RevivalGF.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Abstract
{
    public interface IMealReport
    {
        int MealReportID { get; set; }
        DateTime ReportDate { get; set; }
        decimal Portion { get; set; }
        List<Meal> Meals { get; set; }
        int UserID { get; set; }
        User User { get; set; }
    }
}
