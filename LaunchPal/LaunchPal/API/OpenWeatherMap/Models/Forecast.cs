using System.Collections.Generic;

namespace LaunchPal.API.OpenWeatherMap.Models
{
    public class Forecast
    {
        public City City { get; set; }
        public string Cod { get; set; }
        public double Message { get; set; }
        public int Cnt { get; set; }
        public List<List> List { get; set; }
    }
}