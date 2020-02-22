using GnssCalc;

using System;
using System.Collections.Generic;

namespace GnssCalcTests
{
    internal class TestDateStorage
    {
        internal List<DateTime> DateTimeList { get; }
        internal List<GpsDate> GpsDateList { get; }
        internal List<BdsDate> BdsDateList { get; }
        internal List<YearDoY> YearDoYList { get; }
        internal List<int> DayOfYearList { get; }

        internal TestDateStorage()
        {
            DateTimeList = new List<DateTime>()
            {
                new DateTime(2017, 5, 17),
                new DateTime(2019, 8, 20),
                new DateTime(2006, 1, 1)
            };

            GpsDateList = new List<GpsDate>()
            {
                new GpsDate(1949, 3),
                new GpsDate(2067, 2),
                new GpsDate(1356, 0)
            };

            BdsDateList = new List<BdsDate>()
            {
                new BdsDate(593, 3),
                new BdsDate(711, 2),
                new BdsDate(0, 0)
            };

            DayOfYearList = new List<int>()
            {
                137, 232, 1
            };

            YearDoYList = new List<YearDoY>()
            {
                new YearDoY(2017, 137),
                new YearDoY(2019, 232),
                new YearDoY(2006, 1)
            };
        }

    }
}
