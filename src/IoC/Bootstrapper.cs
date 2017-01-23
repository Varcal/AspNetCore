using Data.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public class Bootstrapper
    {
        public static void RegistrarServicos(IServiceCollection services)
        {

            #region Domamin Services

            #endregion
            
            #region Repositories

            #endregion

            #region Context

            services.AddDbContext<EfContext>();

            #endregion

        }
    }
}
