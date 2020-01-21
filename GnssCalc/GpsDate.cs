using System;

namespace GpsTimeCalc
{
    public struct GpsDate
    {
        public int Weeks { get; set; }
        public int DaysOfWeek { get; set; }

        public GpsDate(int weeks, int daysOfWeek) : this()
        {
            Weeks = weeks;
            DaysOfWeek = daysOfWeek;
        }

        public static explicit operator DateTime(GpsDate gpsTime)
        {
            if (gpsTime.Weeks < 0 || gpsTime.DaysOfWeek < 0 || gpsTime.DaysOfWeek > 6)
                throw new ArgumentException("Invalid GnssDate:" + gpsTime);
            var delta = TimeSpan.FromDays((gpsTime.Weeks * 7) + gpsTime.DaysOfWeek);

            return DateTimeExtension.GPS_START_DATE + delta;
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
