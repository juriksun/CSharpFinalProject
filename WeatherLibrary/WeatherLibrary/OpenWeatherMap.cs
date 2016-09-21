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
                if (instance == null){
                    instance = new OpenWeatherMap();
                }
                return instance;
            }
        }

        public WeatherData GetWeatherData(Location location)
        {
            WeatherData weatherData = new WeatherData();
            var api = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&mode=xml&appid=2fccd10128467348a961d23fc6dc1f59&units=metric", location.Name);
            try
            {

                XDocument xdoc = XDocument.Load(api);
                Console.WriteLine(xdoc.ToString());
                Console.WriteLine(xdoc.Element("current").Element("city").Attribute("name").Value);


            }
            catch (Exception temp)
            {
                Console.WriteLine(temp);
            };

            return weatherData;
        }
    }
}
