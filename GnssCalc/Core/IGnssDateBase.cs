using System;

namespace GnssCalc.Core
{
    public interface IGnssDateBase
    {
        public DateTime StartDate { get; }
        public int Weeks { get; }
        public int DaysOfWeek { get; }
    }
}
