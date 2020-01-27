using GpsTimeCalc.Core;
using GpsTimeCalc.Extensions;
using System;

namespace GpsTimeCalc
{
    public class GpsDate : GnssDateBase
    {
        public GpsDate(int weeks, int daysOfWeek) : base()
        {
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

        public override bool Equals(object obj)
        {
            var gpsObj = obj as GpsDate;
            if (gpsObj == null) return false;

            return gpsObj.DaysOfWeek == DaysOfWeek && gpsObj.Weeks == Weeks && gpsObj.StartDate == StartDate;
        }

    }
}
