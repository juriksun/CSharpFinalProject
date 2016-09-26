//Class for getting data from open weather map.
//by Shamer&Alexander

using System;
using System.Linq;
using System.Xml.Linq;

namespace WeatherLibrary
{
    /// <summary>
    /// Class for getting data from "Open Weather Map" service.</summary>
    /// <remarks>
    /// A class have method which, parse xml data and enter them to WetherData Class.</remarks>
    public class OpenWeatherMap : IWeatherDataService
    {
        /// <summary>
        /// Parameter for singleton instance </summary>
        private static OpenWeatherMap instance;

        /// <summary>
        /// The class private constructor. </summary>
        private OpenWeatherMap() { }

        /// <summary>
        /// Instance property.</summary>
        /// <value>
        /// This is a property for singleton instance.</value>
        public static OpenWeatherMap Instance{
            get{
                return instance = instance ?? new OpenWeatherMap(); ;
            }
        }

        /// <summary>
        /// This is a method for parsing the xml to WetherData Class and return him.
        /// Using the linq to xml.</summary>
        /// <param name="location"> Parameter for location</param>
        public WeatherData GetWeatherData(Location location)
        {
            XDocument xdoc;
            WeatherData weatherData = null;

            var api = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&mode=xml&appid=ad56686c59029eabcaafc0dd0427150a&units=metric", location.Name);
            try
            {
                xdoc = XDocument.Load(api);
                weatherData = new WeatherData();

                //start parsing XML
                var elements = from element in xdoc.Descendants("current")
                               select new
                               {
                                   CytyName = element.Element("city").Attribute("name").Value,
                                   CityCoordLon = element.Element("city").Element("coord").Attribute("lon").Value,
                                   CityCoordLat = element.Element("city").Element("coord").Attribute("lat").Value,
                                   CityCountry = element.Element("city").Element("country").Value,
                                   TempratureValue = element.Element("temperature").Attribute("value").Value,
                                   TempratureMin = element.Element("temperature").Attribute("min").Value,
                                   TempratureMax = element.Element("temperature").Attribute("max").Value,
                                   TempratureUnit = element.Element("temperature").Attribute("unit").Value,
                                   HumidityValue = element.Element("humidity").Attribute("value").Value,
                                   HumidityUnit = element.Element("humidity").Attribute("unit").Value,
                                   PressureValue = element.Element("pressure").Attribute("value").Value,
                                   PressureUnit = element.Element("pressure").Attribute("unit").Value,
                                   WindSpeedValue = element.Element("wind").Element("speed").Attribute("value").Value,
                                   WindSpeedNAme = element.Element("wind").Element("speed").Attribute("name").Value,
                                   CloudsName = element.Element("clouds").Attribute("name").Value,
                                   PrecipitationMode = element.Element("precipitation").Attribute("mode").Value,
                                   WeatherValue = element.Element("weather").Attribute("value").Value,
                                   LastupdateValue = element.Element("lastupdate").Attribute("value").Value
                               };

                foreach (var aElement in elements) {
                    weatherData.City.Name = aElement.CytyName;
                    weatherData.City.Coord.Lon = double.Parse(aElement.CityCoordLon);
                    weatherData.City.Coord.Lat = double.Parse(aElement.CityCoordLat);
                    weatherData.City.Country = aElement.CityCountry;
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
                    weatherData.CloudsName = aElement.CloudsName;
                    weatherData.PrecipitationMode = aElement.PrecipitationMode;
                    weatherData.WeatherValue = aElement.WeatherValue;
                    weatherData.LastUpdateValue = DateTime.Parse(aElement.LastupdateValue);
                }        
                //end of parsing
            }
            catch (Exception e)
            {
                throw new WeatherDataServiceException("Exception in Parsing file.",e);
            }
            return weatherData;
        }
    }
}
