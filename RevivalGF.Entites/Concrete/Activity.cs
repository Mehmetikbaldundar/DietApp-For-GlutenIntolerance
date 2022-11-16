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

        private decimal _ActivityFaktor;
        public decimal ActivityFaktor
        {
            get { return _ActivityFaktor; }
            set { _ActivityFaktor = value; }
        }

        /*private decimal _Calorie;
         public decimal Calorie
        {
            get { return _Calorie; }
            set 
            {
                switch (Activities)
                {
                    case Activities.Fitness:
                        _Calorie = 5 * _ActivityFaktor;
                        break;
                    case Activities.Walking:
                        _Calorie = 4 * _ActivityFaktor;
                        break;
                    case Activities.Cycling:
                        _Calorie = 3 * _ActivityFaktor;
                        break;
                    case Activities.Running:
                        _Calorie = 6 * _ActivityFaktor;
                        break;
                    case Activities.IndoorBike:
                        _Calorie = 4 * _ActivityFaktor;
                        break;
                    case Activities.Yoga:
                        _Calorie = 2 * _ActivityFaktor;
                        break;
                    case Activities.Swimming:
                        _Calorie = 5 * _ActivityFaktor;
                        break;
                    case Activities.Boxing:
                        _Calorie = 6 * _ActivityFaktor;
                        break;
                    case Activities.CircularTraining:
                        _Calorie = 4 * _ActivityFaktor;
                        break;
                    case Activities.Dancing:
                        _Calorie = 6 * _ActivityFaktor;
                        break;
                    case Activities.ExerciseAtHome:
                        _Calorie = 3 * _ActivityFaktor;
                        break;
                    case Activities.FunctionalTraning:
                        _Calorie = 8 * _ActivityFaktor;
                        break;
                    case Activities.Football:
                        _Calorie = 6 * _ActivityFaktor;
                        break;
                    case Activities.KickBox:
                        _Calorie = 4 * _ActivityFaktor;
                        break;
                    case Activities.Rowing:
                        _Calorie = 2 * _ActivityFaktor;
                        break;
                    case Activities.Volleyball:
                        _Calorie = 2 * _ActivityFaktor;
                        break;
                    case Activities.Basketball:
                        _Calorie = 5 * _ActivityFaktor;
                        break;
                    case Activities.Gymnastics:
                        _Calorie = 3 * _ActivityFaktor;
                        break;
                    case Activities.Zumba:
                        _Calorie = 5 * _ActivityFaktor;
                        break;
                }
            }
        }*/

        public List<User> Users { get; set; }
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
