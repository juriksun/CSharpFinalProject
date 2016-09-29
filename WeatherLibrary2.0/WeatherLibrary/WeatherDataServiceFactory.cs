//Class of Weather Data Service Factory
//by Shamir & Alexander

namespace WeatherLibrary
{   /// <summary>
    /// Factory Weather Data Service.</summary>
    /// <remarks>
    /// Class for make other weather services use more easy.</remarks>
    static public class WeatherDataServiceFactory
    {
        /// <summary>
        /// Constant parameter for choosing the "Open Weather Data" service.</summary>
        public const int OPEN_WEATHER_MAP = 0;
        /// <summary>
        /// Constant parameter for choosing the "Another Weather" service.</summary>
        public const int ANOTHER_WEATHER_SERVICE = 1;

        /// <summary>
        /// By this method you can call the service which you want.</summary>
        /// <param name="weatherService"> Parameter for any servers.</param>
        public static IWeatherDataService GetWeatherDataService(int weatherService) {
            IWeatherDataService aWeatherService = null;

            switch (weatherService) {
                case OPEN_WEATHER_MAP:
                    aWeatherService = OpenWeatherMap.Instance;
                    break;
                case ANOTHER_WEATHER_SERVICE:
                    break;
                default:
                    break;
            }
            return aWeatherService;
        }
    }
}
