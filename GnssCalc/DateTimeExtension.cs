using System;

namespace GpsTimeCalc
{
    public static class DateTimeExtension
    {
        public static DateTime GPS_START_DATE => new DateTime(1980, 1, 6);
        public static DateTime BDS_START_DATE => new DateTime(2006, 1, 1);

        public static GpsDate ToGpsTime(this DateTime date)
        {
            var delta = date - GPS_START_DATE;
            if(delta.Days >= 0)
            {
                var weeks = delta.Days / 7;
                var dayOfWeek = delta.Days % 7;
                return new GpsDate() { Weeks = weeks, DaysOfWeek = dayOfWeek };
            }
            throw new ArgumentException("Invalid date: " + date + ", too early");
        }

        public static BdsDate ToBdsTime(this DateTime date)
        {
            var delta = date - BDS_START_DATE;
            if (delta.Days >= 0)
            {
                var weeks = delta.Days / 7;
                var dayOfWeek = delta.Days % 7;
                return new BdsDate() { Weeks = weeks, DaysOfWeek = dayOfWeek };
            }
            throw new ArgumentException("Invalid date: " + date + ", too early");
        }

        public static int ToDayOfYear(this DateTime date)
        {
            var firstDayDate = new DateTime(date.Year, 1, 1);
            var delta = date - firstDayDate;

            return (int)delta.TotalDays + 1;
        }

        public static YearDoY ToYearDoY(this DateTime date) => new YearDoY(date.Year, ToDayOfYear(date));

        public static DateTime ToDateTime(this int dayOfYear, int year)
        {
            var yearDoY = new YearDoY(year, dayOfYear);

            return (DateTime)yearDoY;
        }
    }
}
