using TestArgoApp.Domain;
using TestArgoApp.Domain.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace TestArgoApp.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWeatherServices(this IServiceCollection services)
        {
            return services.AddTransient<IWeatherService, WeatherService>();
        }
    }
}