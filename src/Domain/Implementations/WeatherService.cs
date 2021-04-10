using TestArgoApp.Domain.Abstractions;
using TestArgoApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestArgoApp.Domain.Implementations
{
    internal class WeatherService : IWeatherService
    {
        private readonly IWeatherForecastRepository _weatherRepo;

        public WeatherService(IWeatherForecastRepository weatherRepo)
        {
            _weatherRepo = weatherRepo;
        }

        public Task<IEnumerable<WeatherForecast>> GetFiveDayForecastAsync()
        {
            return _weatherRepo.GetWeatherForecastAsync(5);
        }
    }
}