using RevivalGF.DataAccess.Concrete;
using RevivalGF.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Business.Services
{
    public class NutrientandActivityService
    {
        private readonly RevivalGfDbContext db;
        private readonly UserRepository _userRepository;
        private readonly UserDetailsRepository _detailsRepository;
        private readonly PhysicallyGoalRepository _goalsRepository;
        private readonly BodyAnalysisRepository _bodyAnalysisRepository;
        public NutrientandActivityService()
        {
            db = new RevivalGfDbContext();
            _userRepository = new UserRepository(db);
            _detailsRepository = new UserDetailsRepository(db);
            _goalsRepository = new PhysicallyGoalRepository(db);
            _bodyAnalysisRepository = new BodyAnalysisRepository(db);
        }


    }
}
