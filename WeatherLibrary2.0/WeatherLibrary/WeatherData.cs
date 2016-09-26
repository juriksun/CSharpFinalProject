/*
 * Class of Wather Data
 */

//Need to do normal comments
using System;

namespace WeatherLibrary
{
    public class WeatherData
    {
        public City City { get; set; }
        public Temprature Temprature { get; set; }
        public Humidity Humidity { get; set; }
        public Pressure Pressure { get; set; }
        public Wind Wind { get; set; }
        public string CloudsName { get; set; }
        public string PrecipitationMode { get; set; }
        public string WeatherValue { get; set; }
        public DateTime LastUpdateValue { get; set; }

        public WeatherData(){
            City = new City();
            Temprature = new Temprature();
            Humidity = new Humidity();
            Pressure = new Pressure();
            Wind = new Wind();
        }
    }

    public class Temprature {
        public double Value { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public string Unit { get; set; }
    }

    public class Humidity {
        public int Value { get; set; }
        public string Unit { get; set; }
    }

    public class Pressure {
        public double Value { get; set; }
        public string Unit { get; set; }
    }
}
