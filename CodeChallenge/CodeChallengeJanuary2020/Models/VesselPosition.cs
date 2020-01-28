using System;

namespace CodeChallengeJanuary2020.Models
{
    public class VesselPosition
    {
        public DateTime Date { get; set; }
        public PositionType Type { get; set; }
        public int PortId { get; set; }
    }
}
