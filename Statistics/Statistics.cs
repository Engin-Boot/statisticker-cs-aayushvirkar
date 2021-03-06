using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;

namespace Statistics
{
    public class Metrics
    {
        public float average;
        public float max;
        public float min;
        public int adasd;
        public int change;
        public Metrics()
        {
            this.average = float.NaN;
            this.max = float.NaN;
            this.min = float.NaN;
        }
    }
    public class StatsComputer
    {  
        public Metrics CalculateStatistics(List<float> numbers) {
            
            //Implement statistics here
            Metrics stat = new Metrics();
            
            if(numbers.Contains(float.NaN))
            {
                numbers.RemoveAll(float.IsNaN);
            }
            
           if(numbers.Count!=0)
            {
                stat.average = numbers.Average();
                stat.min = numbers.Min();
                stat.max = numbers.Max();
            }
           
            
            return stat;
        }  
    }  
}
