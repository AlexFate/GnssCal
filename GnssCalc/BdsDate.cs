using GpsTimeCalc.Core;
using GpsTimeCalc.Extensions;

using System;

namespace GpsTimeCalc
{
    public class BdsDate : GnssDateBase
    {
        public BdsDate(int weeks, int daysOfWeek) : base()
        {
            Weeks = weeks;
            DaysOfWeek = daysOfWeek;
            StartDate = new DateTime(2006, 1, 1);
        }

        public static explicit operator DateTime(BdsDate bdsTime)
        {
            if (bdsTime.Weeks < 0 || bdsTime.DaysOfWeek < 0 || bdsTime.DaysOfWeek > 6)
                throw new ArgumentException("Invalid GnssDate:" + bdsTime);
            var delta = TimeSpan.FromDays((bdsTime.Weeks * 7) + bdsTime.DaysOfWeek);
            return bdsTime.StartDate + delta;
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

        public override bool Equals(object obj)
        {
            var bdsObj = obj as BdsDate;
            if (bdsObj == null) return false;

            return bdsObj.DaysOfWeek == DaysOfWeek && bdsObj.Weeks == Weeks && bdsObj.StartDate == StartDate;
        }
    }
}
