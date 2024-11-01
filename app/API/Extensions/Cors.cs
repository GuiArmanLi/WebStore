using System.Collections.Immutable;

namespace src.Extensions;

public static class Cors
{
    public static void CorsSetup(this IServiceCollection services)
    {
        services.AddCors(options =>
            options.AddPolicy("AllowALl", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
    }
}