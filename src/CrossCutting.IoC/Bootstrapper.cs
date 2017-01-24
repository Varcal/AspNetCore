using Application.Contracts;
using Application.Services;
using Domain.Contracts.Repositories;
using Infra.Data.Contexts;
using Infra.Data.Repositories;
using Infra.Data.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.IoC
{
    public class Bootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            #region Application Services

            services.AddScoped<IPessoaAppService, PessoaAppService>();
            #endregion

            #region Domamin Services

            #endregion

            #region Repositories
            services.AddScoped<IPessoaRepository, PessoaRepository>();

            #endregion

            #region Context

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<EfContext>();

            #endregion

        }
    }
}
