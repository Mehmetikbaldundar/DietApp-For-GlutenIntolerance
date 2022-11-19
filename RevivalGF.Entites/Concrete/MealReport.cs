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
    public class MealReport : IMealReport, IBaseEntity
    {
        [Key]
        public int MealReportID { get; set; }
        public DateTime ReportDate { get; set; }
        public decimal Portion { get; set; }
        public List<Meal> Meals { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
        public decimal TotalCalorie { get; set; } = 0;
        public decimal TotalProtein { get; set; } = 0;
        public decimal TotalFat { get; set; } = 0;
        public decimal TotalCarbohydrate { get; set; } = 0;
    }
}
