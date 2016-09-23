using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeatherLibrary
{
    public class OpenWeatherMap : IWeatherDataService
    {
        private static OpenWeatherMap instance;
        private OpenWeatherMap() { }
        public static OpenWeatherMap Instance{
            get{
                return instance = instance ?? new OpenWeatherMap(); ;
            }
        }

        public WeatherData GetWeatherData(Location location)
        {
            XDocument xdoc;
            WeatherData weatherData;

            var api = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&mode=xml&appid=ad56686c59029eabcaafc0dd0427150a&units=metric", location.Name);
            try
            {
                xdoc = XDocument.Load(api);
                weatherData = new WeatherData();

                var elements = from element in xdoc.Descendants("current")
                               select new
                               {
                                   CityId = element.Element("city").Attribute("id").Value,
                                   CytyName = element.Element("city").Attribute("name").Value,
                                   CityCoordLon = element.Element("city").Element("coord").Attribute("lon").Value,
                                   CityCoordLat = element.Element("city").Element("coord").Attribute("lat").Value,
                                   CityCountry = element.Element("city").Element("country").Value,
                                   TempratureValue = element.Element("temperature").Attribute("value").Value,
                                   TempratureMin = element.Element("temperature").Attribute("min").Value,
                                   TempratureMax = element.Element("temperature").Attribute("max").Value,
                                   TempratureUnit = element.Element("temperature").Attribute("unit").Value,
                                   HumidityValue = element.Element("humidity").Attribute("value").Value,
                                   HumidityUnit = element.Element("humidity").Attribute("value").Value,
                                   PressureValue = element.Element("pressure").Attribute("value").Value,
                                   PressureUnit = element.Element("pressure").Attribute("unit").Value,
                                   WindSpeedValue = element.Element("wind").Element("speed").Attribute("value").Value,
                                   WindSpeedName = element.Element("wind").Element("speed").Attribute("name").Value,





                               }
                //start parsing XML with weather data
          



                weatherData.City.Id = Int32.Parse(xdoc.Element("current").Element("city").Attribute("id").Value);

                weatherData.City.Name = xdoc.Element("current").Element("city").Attribute("name").Value;
                weatherData.City.Coord.Lon = Int32.Parse(xdoc.Element("current").Element("city").Element("coord").Attribute("lon").Value);
                weatherData.City.Country = xdoc.Element("current").Element("city").Element("country").Value;
                weatherData.City.Sun.Rise = DateTime.Parse(xdoc.Element("current").Element("city").Attribute("id").Value);

                Console.WriteLine(xdoc.ToString());
                Console.WriteLine(xdoc.Element("current").Element("city").Attribute("name").Value);

                //end parsing

            }
            catch (Exception temp)
            {
                Console.WriteLine(temp);
            };

            return weatherData;
        }
    }
}
