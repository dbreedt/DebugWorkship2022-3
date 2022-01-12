using System;
using DebugWorkshop2022_3.Services;
using Xunit;

namespace WeatherForecastTests
{
    public class WeatherServiceTests
    {
        private readonly WeatherService _service;
        public WeatherServiceTests()
        {
            _service = new WeatherService();
        }

        [Fact]
        public void ThereShouldBe100InTotal()
        {
            Assert.Equal(100, _service.GetAllForecasts().Count);
        }

        [Fact]
        public void ThereShouldBe50Odds()
        {
            Assert.Equal(50, _service.GetAllOdds().Count);
        }

        [Fact]
        public void ThereShouldBe50Evens()
        {
            Assert.Equal(50, _service.GetAllEvens().Count);
        }
    }
}
