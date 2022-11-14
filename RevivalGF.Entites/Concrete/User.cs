using RevivalGF.Entites.Abstract;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Concrete
{
    public class User : IUser, IBaseEntity
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Activity> Activities { get; set; }
        public BodyAnalysis BodyAnalysis { get; set; }
        public List<MealReport> MealReports { get; set; }
        public List<Medicament> Medicaments { get; set; }
        public int GoalID { get; set; }
        public PhysicallyGoal PhysicallyGoal { get; set; }
        public List<Water> Waters { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; }
    }
}
