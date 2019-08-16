using System;
using System.Collections.Generic;
using System.Text;

namespace MSC.BlazXam.Models
{
    public class TimeZone
    {
        public string Code { get; set; }
        public double GmtOffset { get; set; }
        public bool IsDaylightSaving { get; set; }
        public string Name { get; set; }
        public DateTime? NextOffsetChange { get; set; }
    }
}