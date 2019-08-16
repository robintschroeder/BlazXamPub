using System;
using System.Collections.Generic;
using System.Text;

namespace MSC.BlazXam.Models
{
    public class AdministrativeArea
    {
        public string CountryID { get; set; }
        public string EnglishName { get; set; }
        public string EnglishType { get; set; }
        public string ID { get; set; }
        public int Level { get; set; }
        public string LocalizedName { get; set; }
        public string LocalizedType { get; set; }
    }
}