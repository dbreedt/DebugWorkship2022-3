using System;
using System.Collections.Generic;
using System.Linq;

namespace DebugWorkshop2022_3.Services
{
    public class WeatherService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly List<WeatherForecast> _forecasts;

        public WeatherService()
        {
            var rng = new Random();
            _forecasts = Enumerable.Range(1, 100)
                .Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = -20 + (index / 10) * (index % 2 == 0 ? 1 : -1),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .ToList();
        }

        public List<WeatherForecast> GetAllForecasts()
        {
            return _forecasts;
        }

        public List<WeatherForecast> GetAllOdds()
        {
            return _forecasts.Where((v, i) => i % 2 == 1).ToList();
        }

        public List<WeatherForecast> GetAllEvens()
        {
            return _forecasts.Where((v, i) => i % 2 == 0).ToList();
        }
    }
}