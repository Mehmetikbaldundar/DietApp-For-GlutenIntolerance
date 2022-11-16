using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.DataAccess.Concrete
{
    public class UserDetailsRepository : BaseRepository<UserDetails>
    {
        public UserDetailsRepository(RevivalGfDbContext revivalGfDbContext) : base(revivalGfDbContext)
        {
        }
    }
}
