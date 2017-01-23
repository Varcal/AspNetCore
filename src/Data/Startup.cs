using Data.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EfContext>();
        }
    }
}
