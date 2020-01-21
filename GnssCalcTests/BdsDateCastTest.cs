using GpsTimeCalc;

using System;
using System.Collections.Generic;

using Xunit;

namespace GnssCalcTests
{
    public class BdsDateCastTest
    {
        TestDateStorage TDS { get; }
        public BdsDateCastTest() => TDS = new TestDateStorage();

        [Fact]
        public void BdsDateToDateTimeTest()
        {
            var current = new List<DateTime>();

            foreach (var item in TDS.GpsDateList)
            {
                current.Add((DateTime)item);
            }

            Assert.Equal(TDS.DateTimeList, current);
        }

        [Fact]
        public void BdsDateToGpsDateTest()
        {
            var current = new List<GpsDate>();

            foreach (var item in TDS.BdsDateList)
            {
                current.Add((GpsDate)item);
            }

            Assert.Equal(TDS.GpsDateList, current);
        }

        [Fact]
        public void BdsDateToYearDoYTest()
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
