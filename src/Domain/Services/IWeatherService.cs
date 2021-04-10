using TestArgoApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestArgoApp.Domain
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherForecast>> GetFiveDayForecastAsync();
    }
}