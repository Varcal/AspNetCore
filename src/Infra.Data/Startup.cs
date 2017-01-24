using Infra.Data.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Data
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EfContext>();
        }
    }
}
