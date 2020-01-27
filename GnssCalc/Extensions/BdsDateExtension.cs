using System;

namespace GpsTimeCalc.Extensions
{
    public static class BdsDateExtension
    {
        public static DateTime ToDateTime(this BdsDate bdsDate) => (DateTime)bdsDate;

        public static YearDoY ToYearDoY(this BdsDate bdsDate) => (YearDoY)bdsDate;

        public static GpsDate ToGpsDate(this BdsDate bdsDate) => (GpsDate)bdsDate;
    }
}
