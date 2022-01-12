using System.Collections.Generic;
using DebugWorkshop2022_3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DebugWorkshop2022_3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherService _service;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public List<WeatherForecast> Get()
        {
            return _service.GetAllForecasts();
        }
    }
}
