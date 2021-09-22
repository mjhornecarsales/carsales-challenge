using System;
using System.Collections.Generic;
using System.Linq;
using Example.Core.Models;
using Example.Core.Services;

namespace Example.Infrastructure.Services
{
    public class FakeWeatherForecastService : IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = summaries[rng.Next(summaries.Length)]
            })
            .ToArray();
        }
    }

}