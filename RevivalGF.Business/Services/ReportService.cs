using Microsoft.VisualBasic.ApplicationServices;
using RevivalGF.DataAccess.Concrete;
using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Abstract;
using RevivalGF.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = RevivalGF.Entites.Concrete.User;

namespace RevivalGF.Business.Services
{
    public class ReportService
    {
        private readonly RevivalGfDbContext db;
    
        public ReportService()
        {
            db = new RevivalGfDbContext();     
        }
        public decimal CalorieUpdate(decimal sportCalorie,decimal necessaryCalorie) 
        {
           return  necessaryCalorie + sportCalorie;
        }
        public int CircularBarCalorie(decimal currentNecessaryCalories, User user)
        {
            int percentOfTakenCalorie;
            decimal takenCalorie= db.MealReports.Where(x => x.UserID == user.UserID).Select(x => x.TotalCalorie).ToList().Sum();
            return  percentOfTakenCalorie = Convert.ToInt32((takenCalorie * 100) / currentNecessaryCalories);
        }
        public double IdealWeight(UserDetails userdetails)
        {
            double height = userdetails.Height;
            int gender = (int)userdetails.Gender;
            if (gender == 1)
            {
                return 50 + 2.3 * ((height / 2.54) - 60);
            }
            else
            {
                return 45.5 + 2.3 * ((height / 2.54) - 60);
            }
        }
        public string GlutenQuery(User user)
        {
            return db.MealReports.Where(x => x.UserID == user.UserID).Select(x => x.TotalGlutenRisk).ToList().Sum().ToString();
        }

        public string MedicineQuery(User user)
        {
            if (db.Medicaments.Where(x => x.UserID == user.UserID && x.Status == Entites.Enums.Status.Active).FirstOrDefault()==null)
            {              
                return "You did not enter medication information.\r\n";
            }
            else
            {
                return "Don't forget to take your medicine" + db.Medicaments.Where(x => x.UserID == user.UserID && x.Status == Entites.Enums.Status.Active).Select(x => x.MedicamentName).FirstOrDefault().ToString() + " !";
            }
                        
        }
    }
}
