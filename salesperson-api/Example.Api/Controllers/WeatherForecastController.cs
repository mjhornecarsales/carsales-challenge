using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Example.Core.Models;
using Example.Core.Services;

namespace Example.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            this.weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return weatherForecastService.Get();
        }
    }
}
