﻿//Interface of Weather Data Service 
//by Shamir & Alexander

namespace WeatherLibrary
{
    /// <summary>
    /// Interface of Weather Data Service.</summary>
    /// <remarks>
    /// In the future you can add many Weather services and this interface help to control all of them.</remarks>
    public interface IWeatherDataService
    {
        /// <summary>
        /// Method  for getting Weather data</summary>
        /// <param name="location"> Parameter of location.</param>
        WeatherData GetWeatherData(Location location);
    }
}
