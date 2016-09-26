//Location class. Teke the location from user.
//by Shamer&Alexander

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary
{
    public class Location
    {
        public string Name { get; set;}
        public Location(string name) {
            Name = name;
        }
    }   
}
