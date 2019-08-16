using System;
using System.Collections.Generic;
using System.Text;

namespace MSC.BlazXam.Models
{
    public class AccuWeatherCurrentConditModel
    {
        public int EpochTime { get; set; }
        public bool HasPrecipitation { get; set; }
        public bool IsDayTime { get; set; }
        public string Link { get; set; }
        public DateTime LocalObservationDateTime { get; set; }
        public string MobileLink { get; set; }
        public object PrecipitationType { get; set; }
        public Temperature Temperature { get; set; }
        public int WeatherIcon { get; set; }
        public string WeatherText { get; set; }
    }
}