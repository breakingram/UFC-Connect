using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using UFC.WebApp;
using UFC.WebApp.Components;
using UFC.WebApp.Extensions;
using UFC.WebApp.Services;
using UFC.WebApp.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services.AddAuthenticationAndAuthorizationServices(builder.Configuration);
builder.Services.AddDatabaseContexts(builder.Configuration);
builder.Services.AddApplicationCoreServices();
builder.Services.AddRepositoryServices();
builder.Services.AddUseCaseServices();
builder.Services.AddBackupManagementServices();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();

if (app.Environment.IsDevelopment())
    await app.SeedDevelopmentEnvironmentDataAsync();

await app.ApplyDbContextMigrationsAsync();
await app.SeedInitialAdminInProdAsync(builder.Configuration);

await app.EnsureRolesExistAsync();

app.Run();
