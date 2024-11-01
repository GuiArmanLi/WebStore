using Microsoft.OpenApi.Models;

namespace src.Extensions;

public static class Swagger
{
    public static void AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "store"
        }));
    }

    public static void UseSwaggerUi(this IApplicationBuilder builder)
    {
        builder.UseSwagger();
        builder.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "store"));
    }
}