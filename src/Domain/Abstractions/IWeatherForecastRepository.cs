using TestArgoApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestArgoApp.Domain.Abstractions
{
    public interface IWeatherForecastRepository
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync(int numDays);
    }
}