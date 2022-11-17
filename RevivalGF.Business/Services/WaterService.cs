using RevivalGF.DataAccess.Concrete;
using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Business.Services
{
    public class WaterService
    {
        private readonly RevivalGfDbContext db;
        private readonly UserRepository _userRepository;
        private readonly UserDetailsRepository _detailsRepository;
        private readonly WaterRepository _waterRepository;
        public WaterService()
        {
            db = new RevivalGfDbContext();
            _userRepository = new UserRepository(db);
            _detailsRepository = new UserDetailsRepository(db);
            _waterRepository = new WaterRepository(db);
        }
        public void PlummyOffline(User user)
        {
            user.Tutorial = false;
            _userRepository.Update(user);
        }
        public UserDetails GetUserDetails(User user)
        {
            UserDetails userDetails = _detailsRepository.GetById(user.UserID);
            return userDetails;
        }
        public int WaterCount(User user)
        {
            return db.Waters.Where(x => x.UserID == user.UserID && x.Status == Entites.Enums.Status.Active).ToList().Count();
        }
        public int DecreaseWater(User user)
        {
            Water water = db.Waters.Where(x => x.UserID == user.UserID && x.Status == Entites.Enums.Status.Active).OrderByDescending(x=>x.WaterID).FirstOrDefault();
           if (WaterCount(user) > 0)
           {
                _waterRepository.Delete(water);
           }   
            return db.Waters.Where(x => x.UserID == user.UserID && x.Status==Entites.Enums.Status.Active).ToList().Count();
        }

        public int IncreaseWater(User user)
        {  
            Water water = new Water()
            {
               ReportDate = DateTime.Now,
               UserID= user.UserID,
            };
            _waterRepository.Add(water);
            return WaterCount(user);
        }


        #region ProgressBar

     
        #endregion
    }
}
