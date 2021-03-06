using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{1.5F, 8.9F, 3.2F, 4.5F});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{});
            Assert.True(computedStats.average.Equals(float.NaN));
            Assert.True(computedStats.min.Equals(float.NaN));
            Assert.True(computedStats.max.Equals(float.NaN));
                       
        }
        [Fact]
        
        public void whenListContainsNaNthenReportStatsForRestofTheElements()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{1.5f,8.9f,float.NaN,4.5f});
            float epsilon = 0.001F;
             Assert.True(Math.Abs(computedStats.average - 4.9666) <= epsilon);
             Assert.True(Math.Abs(computedStats.max - 8.9) <= epsilon);
             Assert.True(Math.Abs(computedStats.min - 1.5) <= epsilon);
        }
    }
}
