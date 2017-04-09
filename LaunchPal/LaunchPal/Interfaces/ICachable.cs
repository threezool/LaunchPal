using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchPal.API.LaunchLibrary.Models;
using LaunchPal.API.OpenWeatherMap.Models;

namespace LaunchPal.Interfaces
{
    public interface ICachable 
    {
        DateTime ExpireDate { get; set; }
        Launch LaunchInfo { get; set; }
        Mission MissionInfo { get; set; }
        Rocket RocketInfo { get; set; }
        Weather WeatherInfo { get; set; }
    }
}
