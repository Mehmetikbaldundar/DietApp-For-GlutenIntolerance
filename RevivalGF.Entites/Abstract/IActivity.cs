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
    public interface IActivity
    {
        [Key]
        int ActivityID { get; set; }
        decimal ActivityFaktor { get; set; }
        Activities Activity { get; set; }
        float Calorie { get; set; }
        List<User> Users { get; set; }

    }
}
