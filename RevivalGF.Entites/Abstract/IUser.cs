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
        [Key]
        int UserID { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        //USER DETAILS
        string Email { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        // Dil konusu
        Gender Gender { get; set; }
        Cinsiyet Cinsiyet { get; set; }
        double Height { get; set; }
        double Weight { get; set; }

        // Enum Gluten Hassasiyeti
        DateTime BirthDate { get; set; }
        List<Activity> Activities { get; set; }
        BodyAnalysis BodyAnalysis { get; set; }
        List<MealReport> MealReports { get; set; }
        List<Medicament> Medicaments { get; set; }
        int GoalID { get; set; }
        PhysicallyGoal PhysicallyGoal { get; set; }
        List<Water> Waters { get; set; }
    }
}
