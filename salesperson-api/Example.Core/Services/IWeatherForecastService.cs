using System.Collections.Generic;
using Example.Core.Models;

namespace Example.Core.Services
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }

}