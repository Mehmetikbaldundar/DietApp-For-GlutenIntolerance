using RevivalGF.DataAccess.Abstract;
using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Abstract;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.DataAccess.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : class, IBaseEntity
    {
        private readonly RevivalGfDbContext _revivalGfDbContext;
        private readonly DbSet<T> _table;

        public BaseRepository(RevivalGfDbContext revivalGfDbContext)
        {
            _revivalGfDbContext = revivalGfDbContext;
            _table = _revivalGfDbContext.Set<T>();
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
            return _revivalGfDbContext.SaveChanges();
        }

        public bool Update(T entity)
        {
            _revivalGfDbContext.Entry<T>(entity).State = EntityState.Modified;
            return Save() > 0;
        }
    }
}
