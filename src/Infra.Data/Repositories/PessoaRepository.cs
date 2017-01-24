using Domain.Contracts.Repositories;
using Domain.Entities;
using Infra.Data.Contexts;
using Infra.Data.Repositories.Core;

namespace Infra.Data.Repositories
{
    public class PessoaRepository: RepositoryBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(EfContext db) 
            : base(db)
        {
            Db = db;
        }
    }
}
