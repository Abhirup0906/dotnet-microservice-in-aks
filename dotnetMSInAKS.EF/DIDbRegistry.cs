using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace dotnetMSInAKS.EF
{
    public static class DIDbRegistry
    {
        public static void RegisterDependencies(IServiceCollection services, string sqlConnection)
        {
            services.AddDbContext<AdventureDbContext>(options =>
            {
                options.UseSqlServer(sqlConnection);
            });
        }
    }
}
