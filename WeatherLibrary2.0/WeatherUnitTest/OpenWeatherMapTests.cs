using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeatherLibrary.Tests
{
    [TestClass()]
    public class OpenWeatherMapTests
    {
        [TestMethod()]
        public void GetWeatherDataTest()
        {
            Location location = new Location("Vladivostok");
            IWeatherDataService service = OpenWeatherMap.Instance;
            Assert.IsNotNull( service.GetWeatherData(location));
        }
    }
}