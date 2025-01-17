using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using UFC.WebApp.Components.Account;
using UFC.WebApp.Data;
using UFC.WebApp.Services;
using UFC.WebApp.Services.Interfaces;

namespace UFC.WebApp.Extensions
{
    public static class AuthenticationAndAuthorizationServiceExtensions
    {
        public static IServiceCollection AddAuthenticationAndAuthorizationServices(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            // Identity
            services.AddCascadingAuthenticationState();
            services.AddScoped<IdentityUserAccessor>();
            services.AddScoped<IdentityRedirectManager>();
            services.AddScoped<
                AuthenticationStateProvider,
                IdentityRevalidatingAuthenticationStateProvider
            >();

            services
                .AddAuthentication(options =>
                {
                    options.DefaultScheme = IdentityConstants.ApplicationScheme;
                    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
                })
                .AddIdentityCookies();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services
                .AddIdentityCore<ApplicationUser>(options =>
                    options.SignIn.RequireConfirmedAccount = true
                )
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddSignInManager()
                .AddDefaultTokenProviders();

            services.AddSingleton<IEmailSender<ApplicationUser>, IdentityEmailSender>();

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();

            services.AddSingleton<
                IAuthorizationMiddlewareResultHandler,
                AuthorizationMiddlewareResultHandler
            >();

            return services;
        }
    }
}
