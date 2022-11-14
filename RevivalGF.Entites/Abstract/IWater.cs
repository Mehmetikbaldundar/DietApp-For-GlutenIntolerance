using RevivalGF.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Abstract
{
    public interface IWater
    {
        int WaterID { get; set; }
        decimal WaterCount { get; set; }
        DateTime ReportDate { get; set; }
        int UserID { get; set; }
        User User { get; set; }

    }
}
