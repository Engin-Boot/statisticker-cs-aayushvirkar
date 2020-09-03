using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public float average;
        public float max;
        public float min;
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            
           Stats stats = new Metrics();
            
            if(numbers.Count==0)
               {
                   stats.average = float.NaN;
                   stats.max = float.NaN;
                   stats.min = float.NaN;
               }
              else 
               {
                 stats.average = numbers.Average();
                 stats.max = numbers.Max();
                 stats.min = numbers.Min();
               }
          return stats;
        }
    }
}
