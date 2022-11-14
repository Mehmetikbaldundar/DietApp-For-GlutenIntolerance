using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Business.Concrete
{
    public class ActivityRepository : BaseRepository<Activity>
    {
        public ActivityRepository(RevivalGfDbContext revivalGfDbContext) : base(revivalGfDbContext)
        {
        }
    }
}
