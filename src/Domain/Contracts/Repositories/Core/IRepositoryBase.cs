using System.Collections.Generic;
using Domain.Entities.Core;

namespace Domain.Contracts.Repositories.Core
{
    public interface IRepositoryBase<T> where T: EntityBase
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
