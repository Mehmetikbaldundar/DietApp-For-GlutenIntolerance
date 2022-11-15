using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Abstract
{
    public interface IBodyAnalysis
    {
        int AnalysisID { get; set; }
        BodyMassIndex BodyMassIndex { get; set; }
        decimal DietCalorieControl { get; set; }
        User User { get; set; }
    }
}
