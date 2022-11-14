using RevivalGF.Entites.Abstract;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Concrete
{
    public class User : IUser, IBaseEntity
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }       
        public List<Activity> Activities { get; set; }
        public BodyAnalysis BodyAnalysis { get; set; }
        public List<MealReport> MealReports { get; set; }
        public List<Medicament> Medicaments { get; set; }
        public int GoalID { get; set; }
        public PhysicallyGoal PhysicallyGoal { get; set; }
        public Water Water { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; }
        public UserDetails UserDetails { get; set; }
        public bool Tutorial { get; set; }
    }
}
