﻿using System;

using WeatherLibrary;

namespace ConsoleWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing the program
            Location location;
            string nameOfCity;

            IWeatherDataService service = WeatherDataServiceFactory.GetWeatherDataService(WeatherDataServiceFactory.OPEN_WEATHER_MAP);

            for (;;)
            {
                Console.WriteLine("x.For exit.");
                Console.Write("Please enter the name of city: ");
                nameOfCity = Console.ReadLine();
                if(nameOfCity == "x")
                {
                    return;
                }

               location = new Location(nameOfCity);
                try
                {
                    WeatherData testWeather = service.GetWeatherData(location);

                    //place
                    Console.WriteLine("\nPlace: " + testWeather.City.Name
                        + ", " + testWeather.City.Country + " ("
                        + testWeather.City.Coord.Lon + ", " + testWeather.City.Coord.Lat + ")");

                    //temprature
                    Console.WriteLine("Temp: " + testWeather.Temprature.Value +
                        " (min " + testWeather.Temprature.Min + ", max " + testWeather.Temprature.Max + ") " + testWeather.Temprature.Unit);

                    //huidity
                    Console.WriteLine("Humidity: " + testWeather.Humidity.Value + " " + testWeather.Humidity.Unit);

                    //pressure
                    Console.WriteLine("Pressure: " + testWeather.Pressure.Value + " " + testWeather.Pressure.Unit);

                    //wind
                    Console.WriteLine("Wind: " + testWeather.Wind.Speed.Name + " " +
                       testWeather.Wind.Speed.Value);

                    //precipitation
                    Console.WriteLine("Precipitation: " + testWeather.PrecipitationMode);

                    //weather
                    Console.WriteLine("Weather: " + testWeather.WeatherValue);

                    //weather
                    Console.WriteLine("Last Update: " + testWeather.LastUpdateValue.ToLongTimeString());
                }
                catch (WeatherDataServiceException e)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine("\nPress any key to continue...\n");
                Console.ReadKey();
            }
        }
    }
}

