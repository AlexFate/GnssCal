using GpsTimeCalc.Core;
using GpsTimeCalc.Extensions;

using System;

namespace GpsTimeCalc
{
    public struct BdsDate : IGnssDateBase
    {
        public int Weeks { get; }
        public int DaysOfWeek { get; }
        public DateTime StartDate { get; }

        public BdsDate(int weeks, int daysOfWeek) : this()
        {
            if (daysOfWeek >= 7 || daysOfWeek < 0)
                throw new ArgumentOutOfRangeException("DayOfWeek should be in [0 .. 6]. And it was " + daysOfWeek);

            Weeks = weeks;
            DaysOfWeek = daysOfWeek;
            StartDate = new DateTime(2006, 1, 1);
        }

        public static explicit operator DateTime(BdsDate bdsTime)
        {
            if (bdsTime.Weeks < 0 || bdsTime.DaysOfWeek < 0 || bdsTime.DaysOfWeek > 6)
                throw new ArgumentException("Invalid GnssDate:" + bdsTime);
            var delta = TimeSpan.FromDays((bdsTime.Weeks * 7) + bdsTime.DaysOfWeek);
            return bdsTime.StartDate + delta;
        }

        public static explicit operator YearDoY(BdsDate bdsTime)
        {
            var dateTime = (DateTime)bdsTime;
            return dateTime.ToYearDoY();
        }

        public static explicit operator GpsDate(BdsDate bdsTime)
        {
            var dateTime = (DateTime)bdsTime;
            return dateTime.ToGpsTime();
        }

    }
}
