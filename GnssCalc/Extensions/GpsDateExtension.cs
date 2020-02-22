using System;

namespace GnssCalc.Extensions
{
    public static class GpsDateExtension
    {
        public static DateTime ToDateTime(this GpsDate gpsDate) => (DateTime)gpsDate;

        public static YearDoY ToYearDoY(this GpsDate gpsDate) => (YearDoY)gpsDate;

        public static BdsDate ToBdsDate(this GpsDate gpsDate) => (BdsDate)gpsDate;

    }
}
