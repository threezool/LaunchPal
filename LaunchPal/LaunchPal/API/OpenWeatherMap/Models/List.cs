using System;
using System.Collections.Generic;

namespace LaunchPal.API.OpenWeatherMap.Models
{
    public class List
    {
        private int _dt;

        public int Dt
        {
            get { return _dt; }
            set
            {
                // Unix timestamp is seconds past epoch
                DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                Date = dtDateTime;
                _dt = value;
            }
        }

        public DateTime Date { get; set; }
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }
        public Clouds Clouds { get; set; }
        public Wind Wind { get; set; }
        public Rain Rain { get; set; }
        public Snow Snow { get; set; }
        public Sys2 Sys { get; set; }
        public string DtTxt { get; set; }
    }
}