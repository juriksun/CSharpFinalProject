using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary
{
    public class WeatherDataServiceFactory
    {
        public static IWeatherDataService OPEN_WEATHER_MAP(){
            return OpenWeatherMap.Instance;
        }

        public delegate IWeatherDataService WeatherServise();

        public static IWeatherDataService GetWeatherDataService(WeatherServise weatherServise) { 

            return weatherServise();
        }

    }
}
