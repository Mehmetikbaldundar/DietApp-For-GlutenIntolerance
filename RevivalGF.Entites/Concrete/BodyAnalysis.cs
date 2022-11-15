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
    public class BodyAnalysis : IBodyAnalysis, IBaseEntity
    {
        [ForeignKey("User")]
        public int AnalysisID { get; set; }

        private BodyMassIndex _BodyMassIndex;
        public BodyMassIndex BodyMassIndex
        {

            get { return _BodyMassIndex; }
            set
            {
                if (BodyMassIndexCalculator()<=18)
                    _BodyMassIndex = BodyMassIndex.Thin;
                else if (BodyMassIndexCalculator() > 18 && BodyMassIndexCalculator() <= 24)
                    _BodyMassIndex= BodyMassIndex.Normal;
                else if (BodyMassIndexCalculator() > 24 && BodyMassIndexCalculator() <= 29)
                    _BodyMassIndex = BodyMassIndex.OverWeight;
                else if (BodyMassIndexCalculator() > 29 && BodyMassIndexCalculator() <= 35)
                    _BodyMassIndex = BodyMassIndex.FirstDegreeObesity;
                else if (BodyMassIndexCalculator() > 35 && BodyMassIndexCalculator() <= 45)
                    _BodyMassIndex = BodyMassIndex.SecondDegreeObesity;
                else if (BodyMassIndexCalculator() > 45)
                    _BodyMassIndex = BodyMassIndex.ThirdDegreeObesity;
            }
        }

        private decimal _DietCalorieControl;
        public decimal DietCalorieControl
        {
            get { return _DietCalorieControl; }
            set { _DietCalorieControl = DailyCalorieCalculator(); }
        }
        
        public User User { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;

        private int BodyMassIndexCalculator()
        {
            double height = User.UserDetails.Height;
            double weight = User.UserDetails.Weight;
            double heightForMeter = (double)(height / 100);
            return (int)(weight / (heightForMeter * heightForMeter));
        }

        private double BasalMetabolicRate()
        {
            double height = User.UserDetails.Height;
            double weight = User.UserDetails.Weight;
            double age = DateTime.Now.Year-User.UserDetails.BirthDate.Year;
            if (User.UserDetails.Gender == Gender.Man)
                return 66 + (13.7 * weight) + (5 * height) - (6.8 * age);
            else
                return 665 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
        }
        private double RestingMetabolicRate()
        {
            return 1.1*BasalMetabolicRate();
        }
        private decimal ActiveBurn()
        {
            return (decimal)(1.1 * RestingMetabolicRate());
        }
        private decimal ActivityCalculator()
        {
            switch (User.PhysicallyGoal.ActivityStatus)
            {
                case ActivityStatus.LightlyActive:
                    return 1.2M;
                case ActivityStatus.ModeratelyActive:
                    return 1.375M;                  
                case ActivityStatus.Active:
                    return 1.55M;                   
                case ActivityStatus.VeryActive:
                    return 1.9M;                    
            }
            return 1;
        }
        private decimal TargetedCalorieBurn()
        {
            switch (User.PhysicallyGoal.TargetedDiet)
            {
                case TargetedDiet.LoseWeight:
                    return -200;                   
                case TargetedDiet.MaintainWeight:
                    return 0;                    
                case TargetedDiet.GainWeight:
                    return 200;                    
            }
            return 0;
        }
        private decimal DailyCalorieCalculator()
        {
            return (ActiveBurn() * ActivityCalculator())+TargetedCalorieBurn();
        }


    }
}
