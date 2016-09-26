//by Shamer&Alexander
// compile with: /doc:XMLsample.xml

/// <sumary>
///City Data class. Teke the location from user.
/// </sumary>
/// <remarks>
/// Longer comments can be associated with a type or member 
/// through the remarks tag</remarks>


namespace WeatherLibrary {
    public class City {
        /// <summary>
        /// Store for the name property</summary>
        public string Name { get; set; }
        public Coord Coord { get; set; }
        public string Country { get; set; }

        public City(){
            Coord = new Coord();
        }
    }

    public class Coord {
        public double Lon { get; set; }
        public double Lat { get; set; }
    }
}