using System.Collections.Generic;
using System.Linq;
using Domain.Contracts.Repositories.Core;
using Domain.Entities.Core;
using Infra.Data.Contexts;

namespace Infra.Data.Repositories.Core
{
    public class RepositoryBase<T>: IRepositoryBase<T> where T: EntityBase
    {
        protected EfContext Db;

        public RepositoryBase(EfContext db)
        {
            Db = db;
        }

        public virtual void Add(T entity)
        {
            Db.Add(entity);
        }

        public virtual void Update(T entity)
        {
            Db.Update(entity);
        }

        public virtual void Remove(T entity)
        {
            Db.Remove(entity);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return Db.Set<T>().ToList();
        }

        public virtual T GetById(int id)
        {
            return Db.Find<T>(id);
        }
    }
}
