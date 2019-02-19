using System;

namespace MarketLocator.Models
{
    public class Traffic
    {
        public string ANumber { get; set; }

        public string Direction { get; set; }

        public string BNumber { get; set; }

        public DateTime StartDateTime { get; set; }

        public decimal CellLong { get; set; }

        public decimal CellLat { get; set; }
    }
}