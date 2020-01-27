using System;
using System.Collections.Generic;
using System.Text;

namespace GpsTimeCalc.Extensions
{
    public static class YearDoYExtension
    {
        public static DateTime ToDateTime(this YearDoY yearDoY) => (DateTime)yearDoY;

        public static GpsDate ToGpsDate(this YearDoY yearDoY) => (GpsDate)yearDoY;

        public static BdsDate ToBdsDate(this YearDoY yearDoY) => (BdsDate)yearDoY;
    }
}
