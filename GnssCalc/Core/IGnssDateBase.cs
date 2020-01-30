using System;

namespace GpsTimeCalc.Core
{
    public interface IGnssDateBase
    {
        public DateTime StartDate { get; }
        public int Weeks { get; }
        public int DaysOfWeek { get; }
    }
}
