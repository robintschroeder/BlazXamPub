using System;
using System.Collections.Generic;
using System.Text;

namespace MSC.BlazXam.Models
{
    public class Details
    {
        public string BandMap { get; set; }
        public string CanonicalLocationKey { get; set; }
        public string CanonicalPostalCode { get; set; }
        public string Climo { get; set; }
        public DMA DMA { get; set; }
        public string Key { get; set; }
        public string LocalRadar { get; set; }
        public string LocationStem { get; set; }
        public string MarineStation { get; set; }
        public double? MarineStationGMTOffset { get; set; }
        public string MediaRegion { get; set; }
        public string Metar { get; set; }
        public string NXMetro { get; set; }
        public string NXState { get; set; }
        public string PartnerID { get; set; }
        public int Population { get; set; }
        public string PrimaryWarningCountyCode { get; set; }
        public string PrimaryWarningZoneCode { get; set; }
        public string Satellite { get; set; }
        public List<Source> Sources { get; set; }
        public string StationCode { get; set; }
        public double StationGmtOffset { get; set; }
        public string Synoptic { get; set; }
        public string VideoCode { get; set; }
    }
}