using RevivalGF.Entites.Abstract;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Concrete
{
    public class MealReport : IMealReport, IBaseEntity
    {
        public int MealReportID { get; set; }
        public DateTime ReportDate { get; set; }
        public decimal Portion { get; set; }
        public List<Meal> Meals { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; }
    }
}
