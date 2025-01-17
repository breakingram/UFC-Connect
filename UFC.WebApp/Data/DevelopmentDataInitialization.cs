using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UFC.Plugins.EFCoreSqlite;
using UFC.Plugins.InMemory;

namespace UFC.WebApp.Data;

public static class DevelopmentDataInitialization
{
    public static async Task SeedDataAsync(IServiceProvider services, IWebHostEnvironment env)
    {
        var identityContext = services.GetRequiredService<ApplicationDbContext>();
        var ufcContextFactory = services.GetRequiredService<IDbContextFactory<UfcSqliteContext>>();
        var ufcContext = ufcContextFactory.CreateDbContext();

        // Apply migrations
        await identityContext.Database.MigrateAsync();
        await ufcContext.Database.MigrateAsync();

        // Seed Identity Data
        await SeedIdentityDataAsync(identityContext, services);

        // Seed UFC Data
        await SeedUFCDataAsync(ufcContext, services);
    }

    private static async Task SeedIdentityDataAsync(
        ApplicationDbContext context,
        IServiceProvider services
    )
    {
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

        foreach (var role in RoleConstants.AllRoles)
        {
            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));
        }

        // Create Admin User for testing purposes in Dev environment
        var adminEmail = "admin@admin.com";
        var adminUsername = "admin";
        var adminUser = await userManager.FindByNameAsync(adminUsername);
        if (adminUser == null)
        {
            adminUser = new ApplicationUser
            {
                UserName = adminUsername,
                Email = adminEmail,
                EmailConfirmed = true,
            };
            var result = await userManager.CreateAsync(adminUser, "AdminPassword123!");
            if (result.Succeeded)
            {
                // Add "Admin" role
                await userManager.AddToRoleAsync(adminUser, RoleConstants.Admin);

                // Add "Dev" role
                await userManager.AddToRoleAsync(adminUser, RoleConstants.Developer);
            }
            else
            {
                throw new Exception("Failed to create admin user.");
            }
        }

        // Create Non-Admin User
        var userEmail = "user@example.com";
        var userUsername = "user";
        var normalUser = await userManager.FindByNameAsync(userUsername);
        if (normalUser == null)
        {
            normalUser = new ApplicationUser
            {
                UserName = userUsername,
                Email = userEmail,
                EmailConfirmed = true,
            };
            var result = await userManager.CreateAsync(normalUser, "UserPassword123!");
            if (result.Succeeded)
            {
                // Add non admin user
                await userManager.AddToRoleAsync(normalUser, RoleConstants.Viewer);
            }
            else
            {
                throw new Exception("Failed to create normal user.");
            }
        }
    }

    private static async Task SeedUFCDataAsync(
        UfcSqliteContext sqliteContext,
        IServiceProvider services
    )
    {
        if (!await sqliteContext.Fighters.AnyAsync())
        {
            var fighters = GenerateInMemoryFighters.Execute().ToList();
            await sqliteContext.Fighters.AddRangeAsync(fighters);
            await sqliteContext.SaveChangesAsync();
        }

        // if (!await sqliteContext.FighterRequests.AnyAsync())
        // {
        //     var fighterRequests = GenrateTestingFighterRequests.Execute().ToList();
        //     await sqliteContext.FighterRequests.AddRangeAsync(fighterRequests);
        //     await sqliteContext.SaveChangesAsync();
        // }
    }
}
