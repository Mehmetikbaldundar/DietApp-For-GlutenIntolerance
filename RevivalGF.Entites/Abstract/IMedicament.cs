using RevivalGF.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Abstract
{
    public interface IMedicament
    {
        int MedicamentID { get; set; }
        string MedicamentName { get; set; }
        int HourOfUsage { get; set; }
        int TotalUsage { get; set; }
        int UserID { get; set; }
        User User { get; set; }
    }
}
