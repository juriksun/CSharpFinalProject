//Class of City data
//by Shamir & Alexander

namespace WeatherLibrary
{
    public class City
    {
        public string Name { get; set; }
        public Coord Coord { get; set; }
        public string Country { get; set; }
        public City()
        {
            Coord = new Coord();
        }
    }

    public class Coord
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
    }
}