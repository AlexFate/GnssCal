using System;

namespace GpsTimeCalc
{
    public struct BdsDate
    {
        public int Weeks { get; set; }
        public int DaysOfWeek { get; set; }

        public BdsDate(int weeks, int daysOfWeek) : this()
        {
            Weeks = weeks;
            DaysOfWeek = daysOfWeek;
        }

        public static explicit operator DateTime(BdsDate bdsTime)
        {
            if (bdsTime.Weeks < 0 || bdsTime.DaysOfWeek < 0 || bdsTime.DaysOfWeek > 6)
                throw new ArgumentException("Invalid GnssDate:" + bdsTime);
            var delta = TimeSpan.FromDays((bdsTime.Weeks * 7) + bdsTime.DaysOfWeek);

            return DateTimeExtension.BDS_START_DATE + delta;
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
