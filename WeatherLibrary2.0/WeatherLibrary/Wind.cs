//Class of Wind Data
//by Shamer&Alexander

namespace WeatherLibrary
{
    public class Wind
    {
        public Speed Speed { get; set; }
        public Wind() {
            Speed = new Speed();
        }
    }

    public class Speed
    {
        public double Value { get; set; }
        public string Name { get; set; }
    }
}
