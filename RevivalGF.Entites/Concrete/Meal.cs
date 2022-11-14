using RevivalGF.Entites.Abstract;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Concrete
{
    public class Meal : IMeal, IBaseEntity
    {
        [Key]
        public int MealID { get; set; }
        public string MealName { get; set; }
        public string Recipe { get; set; }
        public decimal Calorie { get; set; }
        public decimal Carbonhydrade { get; set; }
        public decimal Fat { get; set; }
        public decimal Protein { get; set; }
        public decimal Gram { get; set; }
        public GlutenRisk GlutenRisk { get; set; }        
        public int? AlternativeFoodID { get; set; }
        public int MealReportID { get; set; }
        public MealReport MealReport { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; }
        public virtual Meal RiskyFoods { get; set; }
        public virtual ICollection<Meal> AlternativeFoods { get; } = new HashSet<Meal>();
        public MealCategories MealCategories { get; set; }
    }
}
