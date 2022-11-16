using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        bool Add(T entity);
        bool AddRange(List<T> entities);
        bool Update(T entity);
        bool Delete(T entity);
        List<T> GetAll();
        T GetById(int Id);

        int Save();
    }
}
