namespace Infra.Data.UoW
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        bool Save();
    }
}
