using System;

namespace GpsTimeCalc.Core
{
    public abstract class GnssDateBase
    {
        internal protected DateTime StartDate { get; set; }
        public int Weeks { get; set; }
        public int DaysOfWeek { get; set; }

    }
}
