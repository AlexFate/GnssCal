using System;

namespace GnssCalc.Extensions
{
    public static class DateTimeExtension
    {
        private static DateTime GpsStartDate => new DateTime(1980, 1, 6);
        private static DateTime BdsStartDate => new DateTime(2006, 1, 1);

        public static GpsDate ToGpsTime(this DateTime date)
        {
            var delta = date - GpsStartDate;
            if (delta.Days >= 0)
            {
                var weeks = delta.Days / 7;
                var dayOfWeek = delta.Days % 7;
                return new GpsDate(weeks, dayOfWeek);
            }
            throw new ArgumentException("Invalid date: " + date + ", too early");
        }

        public static BdsDate ToBdsTime(this DateTime date)
        {
            var delta = date - BdsStartDate;
            if (delta.Days >= 0)
            {
                var weeks = delta.Days / 7;
                var dayOfWeek = delta.Days % 7;
                return new BdsDate(weeks, dayOfWeek);
            }
            throw new ArgumentException("Invalid date: " + date + ", too early");
        }

        public static YearDoY ToYearDoY(this DateTime date) => new YearDoY(date.Year, GetDayOfYear(date));

        private static int GetDayOfYear(this DateTime date)
        {
            var firstDayDate = new DateTime(date.Year, 1, 1);
            var delta = date - firstDayDate;

            return (int)delta.TotalDays + 1;
        }

    }
}
