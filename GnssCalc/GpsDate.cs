using GpsTimeCalc.Core;
using GpsTimeCalc.Extensions;
using System;

namespace GpsTimeCalc
{
    public struct GpsDate : IGnssDateBase
    {
        public DateTime StartDate { get; }

        public int Weeks { get; }
        public int DaysOfWeek { get; }

        public GpsDate(int weeks, int daysOfWeek) : this()
        {
            if (daysOfWeek >= 7 || daysOfWeek < 0)
                throw new ArgumentOutOfRangeException("DayOfWeek should be in [0 .. 6]. And it was " + daysOfWeek);

            Weeks = weeks;
            DaysOfWeek = daysOfWeek;

            StartDate = new DateTime(1980, 1, 6);
        }

        public static explicit operator DateTime(GpsDate gpsTime)
        {
            if (gpsTime.Weeks < 0 || gpsTime.DaysOfWeek < 0 || gpsTime.DaysOfWeek > 6)
                throw new ArgumentException("Invalid GnssDate:" + gpsTime);
            var delta = TimeSpan.FromDays((gpsTime.Weeks * 7) + gpsTime.DaysOfWeek);

            return gpsTime.StartDate + delta;
        }

        public static explicit operator YearDoY(GpsDate gpsTime)
        {
            var dateTime = (DateTime)gpsTime;
            return dateTime.ToYearDoY();
        }

        public static explicit operator BdsDate(GpsDate gpsTime)
        {
            var dateTime = (DateTime)gpsTime;
            return dateTime.ToBdsTime();
        }

    }
}
