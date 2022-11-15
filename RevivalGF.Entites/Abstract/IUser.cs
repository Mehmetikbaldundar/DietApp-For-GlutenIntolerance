using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Abstract
{
    public interface IUser
    {        
        int UserID { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        List<Activity> Activities { get; set; }
        BodyAnalysis BodyAnalysis { get; set; }
        List<MealReport> MealReports { get; set; }
        List<Medicament> Medicaments { get; set; }
        PhysicallyGoal PhysicallyGoal { get; set; }
        Water Water { get; set; }
        UserDetails UserDetails { get; set; }
        bool Tutorial { get; set; }
    }
}
