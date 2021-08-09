using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using Microsoft.Extensions.Configuration;

namespace MusicStore.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigureLogger(configuration.GetValue<string>("DatadogApiKey"), configuration.GetValue<string>("Environment"));
        }

        /// <summary>
        /// Configure logger to write logs to console and Datadog
        /// </summary>
        /// <param name="environment"></param>
        private static void ConfigureLogger(string datadogApiKey, string environment)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.DatadogLogs(
                    apiKey: datadogApiKey,
                    host: Environment.MachineName,
                    tags: new[] { $"env:{environment}" }
                )
                .CreateLogger();
        }
    }
}
