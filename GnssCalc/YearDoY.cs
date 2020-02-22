using GnssCalc.Extensions;

using System;

namespace GnssCalc
{
    public struct YearDoY
    {
        public int Year { get; }
        public int DaysOfYear { get; }

        public YearDoY(int year, int daysOfYear) : this()
        {
            if (year >= 0 && year < 70)
                year += 2000;
            else if (year >= 80 && year < 100)
                year += 1900;
            if (year < 1980 || daysOfYear < 1 || daysOfYear > 366)
                throw new ArgumentException("Days Of Year is invalid: Year: " + year + " DOY: " + daysOfYear);
            Year = year;
            DaysOfYear = daysOfYear;
        }

        public static explicit operator DateTime(YearDoY yearDoY)
        {
            var firstDay = new DateTime(yearDoY.Year, 1, 1);
            var delta = TimeSpan.FromDays(yearDoY.DaysOfYear - 1);
            return firstDay + delta;
        }

        public static explicit operator GpsDate(YearDoY yearDoY)
        {
            var dateTime = (DateTime)yearDoY;
            return dateTime.ToGpsTime();
        }

        public static explicit operator BdsDate(YearDoY yearDoY)
        {
            var dateTime = (DateTime)yearDoY;
            return dateTime.ToBdsTime();
        }

    }
}
