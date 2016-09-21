/*Class of Wind Data*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary
{
    public class Wind
    {
        public Speed Speed { get; set; }
        public Direction Direction { get; set; }
        public Wind() {
            Speed = new Speed();
            Direction = new Direction();
        }
    }

    //Class Of Wind's Speed
    public class Speed
    {
        public double Value { get; set; }
        public string Name { get; set; }
    }

    //Class Of Wind's Direction
    public class Direction {
        public double Derection { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
