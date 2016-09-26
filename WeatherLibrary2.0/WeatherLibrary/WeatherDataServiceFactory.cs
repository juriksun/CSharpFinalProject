//Class of Wether Data Service Factory
//by Shamer&Alexander

namespace WeatherLibrary
{   /// <summary>
    /// Factory Weather Data Service.</summary>
    /// <remarks>
    /// Class for convenience using more weather services.</remarks>
    static public class WeatherDataServiceFactory
    {
        /// <summary>
        /// Constant parameter for choosing the "Open Weather Data" service.</summary>
        public const int OPEN_WEATHER_MAP = 0;
        /// <summary>
        /// Constant parameter for choosing the "Another Weather" service.</summary>
        public const int ANATHE_WEATHER_SERVICE = 1;

        /// <summary>
        /// By this method you can get the service which you want.</summary>
        /// <param name="location"> Parameter for any servers.</param>
        public static IWeatherDataService GetWeatherDataService(int weatherServise) {
            IWeatherDataService aWeatherServise = null;

            switch (weatherServise) {
                case OPEN_WEATHER_MAP:
                    aWeatherServise = OpenWeatherMap.Instance;
                    break;
                case ANATHE_WEATHER_SERVICE:
                    break;
                default:
                    break;
            }
            return aWeatherServise;
        }
    }
}
