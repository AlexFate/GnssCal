using GpsTimeCalc.Extensions;
using System;

namespace GpsTimeCalc
{
    public struct YearDoY
    {
        public int Year { get; set; }
        public int DaysOfYear { get; set; }

        public YearDoY(int year, int daysOfYear) : this()
        {
            if (year < 1980 || daysOfYear < 1 || daysOfYear > 366)
                throw new ArgumentException("Year or daysOfYear is invalid: Year: " + year + " DOY: " + daysOfYear);
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
