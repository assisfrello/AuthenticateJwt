using AuthenticateJwt.Services;
using AuthenticateJwt.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AuthenticateJwt.CrossCutting;

public static class DependencyInjector
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticateService, AuthenticateService>();
    }
}