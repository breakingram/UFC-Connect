using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UFC.Plugins.EFCoreSqlite;
using UFC.WebApp.Data;

namespace UFC.WebApp.Extensions;

public static class DbContextMigrationsExtensions
{
    public static async Task ApplyDbContextMigrationsAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;

        try
        {
            var configuration = services.GetRequiredService<IConfiguration>();
            var environment = app.Environment;

            var identityContext = services.GetRequiredService<ApplicationDbContext>();
            await identityContext.Database.MigrateAsync();

            var ufcContext = services.GetRequiredService<UfcSqliteContext>();
            await ufcContext.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while applying migrations: {ex.Message}");
        }
    }

    public static async Task EnsureRolesExistAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        foreach (var role in RoleConstants.AllRoles)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }
    }
}
