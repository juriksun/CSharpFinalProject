/*
 * Class of Wather Data
 */

//Need to do normal comments
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary
{
    public class WeatherData
    {
        public City City { get; set; }
        public Temprature Temprature { get; set; }
        public Humidity Humidity { get; set; }
        public Pressure Pressure { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public string Mode { get; set; }
        public Weather Weather { get; set; }
        public DateTime LastUpdateValue { get; set; }

        public WeatherData(){
            City = new City();
            Temprature = new Temprature();
            Humidity = new Humidity();
            Pressure = new Pressure();
            Wind = new Wind();
            Clouds = new Clouds();
            Weather = new Weather();
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

    public class Clouds {
        public int Value { get; set; }
        public string Name { get; set; }
    }

    public class Weather {
        public int Number { get; set; }
        public string Value { get; set; }
        public string icon { get; set; }
    }
}
