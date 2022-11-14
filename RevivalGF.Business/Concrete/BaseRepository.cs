using RevivalGF.Business.Abstract;
using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Abstract;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Business.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : class, IBaseEntity
    {
        private readonly RevivalGfDbContext _revivalDbContext;
        private DbSet<T> _table;

        public BaseRepository(RevivalGfDbContext revivalGfDbContext)
        {
            _revivalDbContext = revivalGfDbContext;
            _table = _revivalDbContext.Set<T>();
        }
        public bool Add(T entity)
        {
            _table.Add(entity);
            return Save() > 0;
        }

        public bool AddRange(List<T> entities)
        {
            _table.AddRange(entities);
            return Save() > 0;
        }

        public bool Delete(T entity)
        {
            entity.Status = Status.Deleted;
            return Update(entity);
        }

        public List<T> GetAll()
        {
            return _table.Where(x => x.Status == Status.Active || x.Status == Status.Modified).ToList();
        }

        public T GetById(int Id)
        {
            return _table.Find(Id);
        }

        public int Save()
        {
            return _revivalDbContext.SaveChanges();
        }

        public bool Update(T entity)
        {
            _revivalDbContext.Entry<T>(entity).State = EntityState.Modified;
            return Save() > 0;
        }
    }
}
