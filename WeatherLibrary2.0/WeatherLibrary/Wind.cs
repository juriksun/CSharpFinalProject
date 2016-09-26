/*Class of Wind Data*/

namespace WeatherLibrary
{
    public class Wind
    {
        public Speed Speed { get; set; }
        public Wind() {
            Speed = new Speed();
        }
    }

    //Class Of Wind's Speed
    public class Speed
    {
        public double Value { get; set; }
        public string Name { get; set; }
    }
}
