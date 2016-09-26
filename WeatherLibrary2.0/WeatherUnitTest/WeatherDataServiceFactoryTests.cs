using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeatherLibrary.Tests
{
    [TestClass()]
    public class WeatherDataServiceFactoryTests
    {
        [TestMethod()]
        public void GetWeatherDataServiceTest()
        {
            OpenWeatherMap testWeather = OpenWeatherMap.Instance;
            Assert.AreEqual(WeatherDataServiceFactory.GetWeatherDataService(WeatherDataServiceFactory.OPEN_WEATHER_MAP).GetType().Name, testWeather.GetType().Name);
        }
    }
}