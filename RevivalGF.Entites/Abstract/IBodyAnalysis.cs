﻿using RevivalGF.Entites.Concrete;
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
        float BodyMassIndex { get; set; }        
        User User { get; set; }
    }
}
