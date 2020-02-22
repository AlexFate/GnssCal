using System;

namespace GnssCalc.Extensions
{
    public static class YearDoYExtension
    {
        public static DateTime ToDateTime(this YearDoY yearDoY) => (DateTime)yearDoY;

        public static GpsDate ToGpsDate(this YearDoY yearDoY) => (GpsDate)yearDoY;

        public static BdsDate ToBdsDate(this YearDoY yearDoY) => (BdsDate)yearDoY;
    }
}
