using GpsTimeCalc;
using System;
using System.Collections.Generic;

using Xunit;

namespace GnssCalcTests
{
    public class YearDoYCastTest
    {
        TestDateStorage TDS { get; }

        public YearDoYCastTest() => TDS = new TestDateStorage();

        [Fact]
        public void YearDoY2DateTimeTest()
        {
            var current = new List<DateTime>();

            foreach (var item in TDS.YearDoYList)
            {
                current.Add((DateTime)item);
            }

            Assert.Equal(TDS.DateTimeList, current);
        }

        [Fact]
        public void YearDoY2GpsDateTest()
        {
            var current = new List<GpsDate>();

            foreach (var item in TDS.YearDoYList)
            {
                current.Add((GpsDate)item);
            }

            Assert.Equal(TDS.GpsDateList, current);

        }

        [Fact]
        public void YearDoY2BdsDateTest()
        {
            var current = new List<BdsDate>();

            foreach (var item in TDS.YearDoYList)
            {
                current.Add((BdsDate)item);
            }

            Assert.Equal(TDS.BdsDateList, current);
        }
    }
}
