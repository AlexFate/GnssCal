using System;

namespace GpsTimeCalc.Extensions
{
    public static class GpsDateExtension
    {
        public static DateTime ToDateTime(this GpsDate gpsDate) => (DateTime)gpsDate;

        public static YearDoY ToYearDoY(this GpsDate gpsDate) => (YearDoY)gpsDate;

        public static BdsDate ToGpsDate(this GpsDate gpsDate) => (BdsDate)gpsDate;

    }
}
