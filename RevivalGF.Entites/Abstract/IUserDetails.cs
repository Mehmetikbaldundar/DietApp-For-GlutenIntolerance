using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Abstract
{
    public interface IUserDetails
    {        
        int DetailsID { get; set; }
        string Email { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        Gender Gender { get; set; }
        double Height { get; set; }
        double Weight { get; set; }
        GlutenIntolerance GlutenIntolerance { get; set; }
        DateTime BirthDate { get; set; }
        User User { get; set; }

    }
}
