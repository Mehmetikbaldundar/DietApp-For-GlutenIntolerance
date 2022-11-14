using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Abstract
{
    public interface IPhysicallyGoal
    {
        int GoalID { get; set; }
        TargetedDiet TargetedDiet { get; set; }
        ActivityStatus ActivityStatus { get; set; }
        decimal DietCalorieControl { get; set; }
        List<User> Users { get; set; }
    }
}
