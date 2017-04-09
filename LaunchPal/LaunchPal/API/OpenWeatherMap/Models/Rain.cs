using Newtonsoft.Json;

namespace LaunchPal.API.OpenWeatherMap.Models
{
    public class Rain
    {
        [JsonProperty(PropertyName = "3H")]
        public double? ThreeHours { get; set; }
    }
}