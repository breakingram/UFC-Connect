using UFC.WebApp.Services;

namespace UFC.WebApp.Extensions
{
    public static class BackupManagementServiceExtensions
    {
        public static IServiceCollection AddBackupManagementServices(
            this IServiceCollection services
        )
        {
            services.AddSingleton<DatabaseBackupService>();
            services.AddHostedService<DatabaseBackupBackgroundService>();

            return services;
        }
    }
}
