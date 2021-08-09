using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace MusicStore.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterApiDependencies(this IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MusicStore.Api", Version = "v1" });
            });
        }
    }
}