using GnssCalc;

using System;
using System.Collections.Generic;

using Xunit;

namespace GnssCalcTests
{
    public class GpsDateCastTest
    {
        TestDateStorage TDS { get; }
        public GpsDateCastTest() => TDS = new TestDateStorage();

        [Fact]
        public void GpsDateToDateTimeTest()
        {
            var current = new List<DateTime>();

            foreach (var item in TDS.GpsDateList)
            {
                current.Add((DateTime)item);
            }

            Assert.Equal(TDS.DateTimeList, current);
        }

        [Fact]
        public void GpsDateToBdsDateTest()
        {
            var current = new List<BdsDate>();

            foreach (var item in TDS.GpsDateList)
            {
                current.Add((BdsDate)item);
            }

            Assert.Equal(TDS.BdsDateList, current);
        }

        [Fact]
        public void GpsDateToYearDoYTest()
        {
            var current = new List<YearDoY>();

            foreach (var item in TDS.GpsDateList)
            {
                current.Add((YearDoY)item);
            }

            Assert.Equal(TDS.YearDoYList, current);
        }
    }
}
