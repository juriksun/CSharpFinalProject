/*Class Of City Data*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary {
    public class City {

        public int Id { get; set; }
        public string Name { get; set; }
        public Coord Coord { get; set; }
        public string Country { get; set; }
        public Sun Sun { get; set; }

        public City(){
            Coord = new Coord();
            Sun = new Sun();
        }
    }

    public class Coord {
        public double Lon { get; set; }
        public double Lat { get; set; }
    }

    public class Sun {
        public DateTime Rise { get; set; }
        public DateTime Set { get; set; }
    }

}
