using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchPal.API.LaunchLibrary.Models;
using LaunchPal.API.OpenWeatherMap.Models;
using LaunchPal.Interfaces;

namespace LaunchPal.Models
{
    class LaunchData : ICachable
    {
        public DateTime ExpireDate { get; set; }
        public Launch LaunchInfo { get; set; }
        public Mission MissionInfo { get; set; }
        public Rocket RocketInfo { get; set; }
        public Weather WeatherInfo { get; set; }
    }
}
