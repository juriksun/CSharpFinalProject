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
            WeatherData weatherData = null;

            var api = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&mode=xml&appid=ad56686c59029eabcaafc0dd0427150a&units=metric", location.Name);
            try
            {
                xdoc = XDocument.Load(api);
                weatherData = new WeatherData();

                //start parsing XML with weather data

                var elements = from element in xdoc.Descendants("current")
                               select new
                               {
                                   CityId = element.Element("city").Attribute("id").Value,
                                   CytyName = element.Element("city").Attribute("name").Value,
                                   CityCoordLon = element.Element("city").Element("coord").Attribute("lon").Value,
                                   CityCoordLat = element.Element("city").Element("coord").Attribute("lat").Value,
                                   CityCountry = element.Element("city").Element("country").Value,
                                   CitySunRise = element.Element("city").Element("sun").Attribute("rise").Value,
                                   CitySunSet = element.Element("city").Element("sun").Attribute("set").Value,
                                   TempratureValue = element.Element("temperature").Attribute("value").Value,
                                   TempratureMin = element.Element("temperature").Attribute("min").Value,
                                   TempratureMax = element.Element("temperature").Attribute("max").Value,
                                   TempratureUnit = element.Element("temperature").Attribute("unit").Value,
                                   HumidityValue = element.Element("humidity").Attribute("value").Value,
                                   HumidityUnit = element.Element("humidity").Attribute("value").Value,
                                   PressureValue = element.Element("pressure").Attribute("value").Value,
                                   PressureUnit = element.Element("pressure").Attribute("unit").Value,
                                   WindSpeedValue = element.Element("wind").Element("speed").Attribute("value").Value,
                                   WindSpeedNAme = element.Element("wind").Element("speed").Attribute("name").Value,
                                   WindDirectionValue = element.Element("wind").Element("speed").Attribute("value").Value,
                                   WindDirectioCode = element.Element("wind").Element("direction").Attribute("code").Value,
                                   WindDirectioName = element.Element("wind").Element("direction").Attribute("name").Value,
                                   CloudsValue = element.Element("clouds").Attribute("value").Value,
                                   CloudsName = element.Element("clouds").Attribute("name").Value,
                                   PrecipitationMode = element.Element("precipitation").Attribute("mode").Value,
                                   WeatherNumber = element.Element("weather").Attribute("number").Value,
                                   WeatherValue = element.Element("weather").Attribute("value").Value,
                                   WeatherIcon = element.Element("weather").Attribute("icon").Value,
                                   LastupdateValue = element.Element("lastupdate").Attribute("value").Value
                               };

                foreach (var aElement in elements) {

                    weatherData.City.Name = aElement.CytyName;
                    weatherData.City.Coord.Lon = double.Parse(aElement.CityCoordLon);
                    weatherData.City.Coord.Lat = double.Parse(aElement.CityCoordLat);
                    weatherData.City.Country = aElement.CityCountry;
                    weatherData.City.Sun.Rise = DateTime.Parse(aElement.CitySunRise);
                    weatherData.City.Sun.Set = DateTime.Parse(aElement.CitySunSet);
                    weatherData.Temprature.Value = double.Parse(aElement.TempratureValue);
                    weatherData.Temprature.Min = double.Parse(aElement.TempratureMin);
                    weatherData.Temprature.Max = double.Parse(aElement.TempratureMax);
                    weatherData.Temprature.Unit = aElement.TempratureUnit;
                    weatherData.Humidity.Value = Int32.Parse(aElement.HumidityValue);
                    weatherData.Humidity.Unit = aElement.HumidityUnit;
                    weatherData.Pressure.Value = double.Parse(aElement.PressureValue);
                    weatherData.Pressure.Unit = aElement.PressureUnit;
                    weatherData.Wind.Speed.Value = double.Parse(aElement.WindSpeedValue);
                    weatherData.Wind.Speed.Name = aElement.WindSpeedNAme;
                    weatherData.Wind.Direction.Value = double.Parse(aElement.WindDirectionValue);
                    weatherData.Wind.Direction.Code = aElement.WindDirectioCode;
                    weatherData.Wind.Direction.Name = aElement.WindDirectioName;
                    weatherData.Clouds.Value = Int32.Parse(aElement.CloudsValue);
                    weatherData.Clouds.Name = aElement.CloudsName;
                    weatherData.PrecipitationMode = aElement.PrecipitationMode;
                    weatherData.Weather.Number = Int32.Parse(aElement.WeatherNumber);
                    weatherData.Weather.Value = aElement.WeatherValue;
                    weatherData.Weather.Icon = aElement.WeatherIcon;
                    weatherData.LastUpdateValue = DateTime.Parse(aElement.LastupdateValue);
                }        
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
