using DebugWorkshop2022_3.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeatherForecastTests
{
    [TestClass]
    public class WeatherServiceTests
    {
        private readonly WeatherService _service;
        public WeatherServiceTests()
        {
            _service = new WeatherService();
        }

        [TestMethod]
        public void ThereShouldBe100InTotal()
        {
            Assert.AreEqual(100, _service.GetAllForecasts().Count);
        }

        [TestMethod]
        public void ThereShouldBe50Odds()
        {
            Assert.AreEqual(50, _service.GetAllOdds().Count);
        }

        [TestMethod]
        public void ThereShouldBe50Evens()
        {
            Assert.AreEqual(50, _service.GetAllEvens().Count);
        }
    }
}
