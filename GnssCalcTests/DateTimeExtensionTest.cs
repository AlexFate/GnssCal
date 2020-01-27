using GpsTimeCalc.Extensions;
using GpsTimeCalc;

using System.Collections.Generic;

using Xunit;

namespace GnssCalcTests
{
    public class DateTimeExtensionTest
    {
        TestDateStorage TDS { get; }

        public DateTimeExtensionTest() => TDS = new TestDateStorage();

        [Fact]
        public void DateTime2GnssDateTest()
        {
            var current = new List<GpsDate>();

            foreach (var item in TDS.DateTimeList)
            {
                current.Add(item.ToGpsTime());
            }

            Assert.Equal(TDS.GpsDateList, current);
        }

        [Fact]
        public void DateTime2YearDoYTest()
        {
            var current = new List<YearDoY>();

            foreach (var item in TDS.DateTimeList)
            {
                current.Add(item.ToYearDoY());
            }

            Assert.Equal(TDS.YearDoYList, current);
        }

        [Fact]
        public void DateTime2BdsDateTest()
        {
            var current = new List<BdsDate>();

            foreach (var item in TDS.DateTimeList)
            {
                current.Add(item.ToBdsTime());
            }

            Assert.Equal(TDS.BdsDateList, current);
        }
    }
}
