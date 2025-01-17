using Microsoft.EntityFrameworkCore;
using UFC.Plugins.EFCoreSqlite;
using UFC.WebApp.Data;

namespace UFC.WebApp.Extensions
{
    public static class DbContextServiceExtensions
    {
        public static IServiceCollection AddDatabaseContexts(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            var identityDBConnectionString =
                configuration.GetConnectionString("IdentityDB")
                ?? throw new InvalidOperationException("Connection string 'IdentityDB' not found.");

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(identityDBConnectionString)
            );

            services.AddDbContextFactory<UfcSqliteContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("UFCDB"));
            });

            return services;
        }
    }
}
