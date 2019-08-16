using System;

namespace MSC.BlazXam.Xam.Models
{
    public class Item
    {
        public string City { get; set; }
        public string CityDetails { get { return $"{City} - Population: {String.Format("{0:n0}", Population)}"; } }
        public string Country { get; set; }
        public string Id { get; set; }
        public int Population { get; set; }
    }
}