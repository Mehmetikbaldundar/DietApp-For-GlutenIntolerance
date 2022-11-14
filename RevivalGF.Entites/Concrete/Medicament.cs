using RevivalGF.Entites.Abstract;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Concrete
{
    public class Medicament : IMedicament, IBaseEntity
    {
        public int MedicamentID { get; set; }
        public string MedicamentName { get; set; }
        public int HourOfUsage { get; set; }
        public int TotalUsage { get; set; }
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
