using System;
using Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infra.Data.UoW
{
    public class UnitOfWork: IUnitOfWork, IDisposable
    {
        private readonly EfContext _db;
        private IDbContextTransaction _transaction;

        public UnitOfWork(EfContext db)
        {
            _db = db;
        }

        public void BeginTransaction()
        {
           _transaction =  _db.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _db?.Dispose();
            _transaction?.Dispose();
        }
    }
}
