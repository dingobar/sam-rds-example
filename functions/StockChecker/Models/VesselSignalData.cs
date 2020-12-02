using System;

namespace StockChecker.Models
{
    class VesselSignalData
    {
        public int vesselimo { get; set; }
        public string signal { get; set; }
        public DateTime datetime { get; set; }
        public double value { get; set; }
    }
}