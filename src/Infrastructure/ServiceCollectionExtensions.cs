using TestArgoApp.Domain.Abstractions;
using TestArgoApp.Infrastructure.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace TestArgoApp.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWeatherForecastRepository(this IServiceCollection services)
        {
            return services.AddTransient<IWeatherForecastRepository, RandomWeatherForecastRepository>();
        }
    }
}