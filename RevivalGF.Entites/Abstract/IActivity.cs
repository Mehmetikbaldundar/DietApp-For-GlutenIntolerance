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
        int ActivityID { get; set; }
        Activities Activities { get; set; }
        decimal ActivityFaktor { get; set; }       
        decimal Calorie { get; set; }
        List<User> Users { get; set; }

    }
}
