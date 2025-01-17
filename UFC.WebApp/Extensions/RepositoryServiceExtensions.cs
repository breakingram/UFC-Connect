using UFC.Plugins.EFCoreSqlite;
using UFC.Plugins.Filters;
using UFC.UseCases.PluginInterfaces;

namespace UFC.WebApp.Extensions
{
    public static class RepositoryServiceExtensions
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            // Uncommnet below line to use in-memory data
            // services.AddSingleton<IFighterRepository, FighterRepository>();

            services.AddTransient<IFighterRepository, FighterEFCoreRepository>();
            services.AddTransient<IFighterRequestRepository, FighterRequestEFCoreRepository>();

            services.AddSingleton<IFighterFilterRepository, FighterFilterRepository>();
            services.AddSingleton<IFighterStatusFilterRepository, FighterStatusFilterRepository>();

            return services;
        }
    }
}
