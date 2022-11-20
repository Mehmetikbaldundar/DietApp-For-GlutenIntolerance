using RevivalGF.DataAccess.Concrete;
using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Abstract;
using RevivalGF.Entites.Concrete;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevivalGF.Business.Services
{
    public class ActivityService
    {

        private readonly RevivalGfDbContext db;
        private readonly ActivityRepository _activityRepository;        
        public ActivityService()
        {
            db = new RevivalGfDbContext();
            _activityRepository = new ActivityRepository(db);            
        }

        public bool ActivityAdd(Activity activity)
        {
            switch (activity.Activities)
            {
                case Activities.Fitness:
                    activity.Calorie = 5 * activity.ActivityFaktor;
                    break;
                case Activities.Walking:
                    activity.Calorie = 4 * activity.ActivityFaktor;
                    break;
                case Activities.Cycling:
                    activity.Calorie = 3 * activity.ActivityFaktor;
                    break;
                case Activities.Running:
                    activity.Calorie = 6 * activity.ActivityFaktor;
                    break;
                case Activities.IndoorBike:
                    activity.Calorie = 4 * activity.ActivityFaktor;
                    break;
                case Activities.Yoga:
                    activity.Calorie = 2 * activity.ActivityFaktor;
                    break;
                case Activities.Swimming:
                    activity.Calorie = 5 * activity.ActivityFaktor;
                    break;
                case Activities.Boxing:
                    activity.Calorie = 6 * activity.ActivityFaktor;
                    break;
                case Activities.CircularTraining:
                    activity.Calorie = 4 * activity.ActivityFaktor;
                    break;
                case Activities.Dancing:
                    activity.Calorie = 6 * activity.ActivityFaktor;
                    break;
                case Activities.ExerciseAtHome:
                    activity.Calorie = 3 * activity.ActivityFaktor;
                    break;
                case Activities.FunctionalTraning:
                    activity.Calorie = 8 * activity.ActivityFaktor;
                    break;
                case Activities.Football:
                    activity.Calorie = 6 * activity.ActivityFaktor;
                    break;
                case Activities.KickBox:
                    activity.Calorie = 4 * activity.ActivityFaktor;
                    break;
                case Activities.Rowing:
                    activity.Calorie = 2 * activity.ActivityFaktor;
                    break;
                case Activities.Volleyball:
                    activity.Calorie = 2 * activity.ActivityFaktor;
                    break;
                case Activities.Basketball:
                    activity.Calorie = 5 * activity.ActivityFaktor;
                    break;
                case Activities.Gymnastics:
                    activity.Calorie = 3 * activity.ActivityFaktor;
                    break;
                case Activities.Zumba:
                    activity.Calorie = 5 * activity.ActivityFaktor;
                    break;
            }
            _activityRepository.Add(activity);
            return true;
        }
        public void DailyActivities(DataGridView dataGridView, User user)
        {
            dataGridView.DataSource = db.Activities.Where(x => x.UserID == user.UserID).Where(x => x.DeletedDate == null)
                .Select(x => new
                {
                    x.ActivityID,
                    x.Activities,
                    Minutes = x.ActivityFaktor,
                    CalorieBurn = x.Calorie,
                    Date = x.CreatedDate,

                }).Where(x => x.Date.Day == DateTime.Now.Day).ToList();
        }
        public string CalorieBurn(Label label, User user)
        {
            if (db.Activities.Where(x => x.UserID == user.UserID && x.Status == Status.Active).FirstOrDefault() == null)
                label.Text = "0";
            else
            {
                label.Text = db.Activities.Where(x => x.UserID == user.UserID).Where(x => x.DeletedDate == null)
                            .Select(x => new
                            {
                                CalorieBurn = x.Calorie,
                            }).Sum(x => x.CalorieBurn).ToString();
            }
            return label.Text;
        }
        public void ActivityDelete(int selectedActivtyID)
        {
            var ActivityDelete = _activityRepository.GetById(selectedActivtyID);
            ActivityDelete.DeletedDate = DateTime.Now;
            _activityRepository.Delete(ActivityDelete);
        }

    }
}
