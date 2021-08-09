using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using MusicStore.Api.Models;

namespace MusicStore.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterApiDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

            var swaggerConfig = configuration.GetSection("Swagger").Get<SwaggerConfigModel>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(swaggerConfig.Version, new OpenApiInfo { Title = swaggerConfig.Title, Version = swaggerConfig.Version});
            });
        }
    }
}