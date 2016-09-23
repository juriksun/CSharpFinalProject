using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the name of city: ");
            Location location = new Location(Console.ReadLine());
            IWeatherDataService service = WeatherDataServiceFactory.GetWeatherDataService(WeatherDataServiceFactory.OPEN_WEATHER_MAP);
            service.GetWeatherData(location);
            Console.ReadLine();
        }
    }
}
