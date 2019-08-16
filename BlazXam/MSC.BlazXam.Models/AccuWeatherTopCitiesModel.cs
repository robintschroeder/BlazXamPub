using System;
using System.Collections.Generic;
using System.Text;

namespace MSC.BlazXam.Models
{
    public class AccuWeatherTopCitiesModel
    {
        public AdministrativeArea AdministrativeArea { get; set; }
        public Country Country { get; set; }
        public List<object> DataSets { get; set; }
        public Details Details { get; set; }
        public string EnglishName { get; set; }
        public GeoPosition GeoPosition { get; set; }
        public bool IsAlias { get; set; }
        public string Key { get; set; }
        public string LocalizedName { get; set; }
        public string PrimaryPostalCode { get; set; }
        public int Rank { get; set; }
        public Region Region { get; set; }
        public List<object> SupplementalAdminAreas { get; set; }
        public TimeZone TimeZone { get; set; }
        public string Type { get; set; }
        public int Version { get; set; }
    }
}