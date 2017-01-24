using System;
using Infra.Data.UoW;

namespace Application.Services.Core
{
    public abstract class ApplicationService
    {
        private readonly IUnitOfWork _uow;

        protected ApplicationService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void BeginTransaction()
        {
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.Commit();
        }

        public void RollBack()
        {
            _uow.Rollback();
        }

        public bool Salvar()
        {
            return _uow.Save();
        }
    }
}
