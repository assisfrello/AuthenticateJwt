using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace AuthenticateJwt.Configuration;

public static class SwaggerConfig
{
    public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "Authenticate Bearer Token"
            });
            c.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "Authenticate", Version = "v1",
                    Description = "<h3>API para Atenticação JWT</h3><h4><b>Autorização:</b></h4><p>Crie sua autenticação através de seu Token, utilizando a chave \"ChaveSecretaParaGerarBearerTokenHeHeHeHe\"</p>",
                    Contact = new OpenApiContact { Name = "Nome contato", Email = "suporte@seuprovedor.com", Url = new Uri("https://seudominio.com/") }
                });
        });
            
        return services;
    }
}