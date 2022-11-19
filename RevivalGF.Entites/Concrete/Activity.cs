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
    public class Activity : IActivity, IBaseEntity
    {
        [Key]
        public int ActivityID { get; set; }
        public Activities Activities { get; set; }        
        public decimal ActivityFaktor { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; } 
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
        public decimal Calorie { get; set; }
    }
}
