using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class Metrics
    {
        public float average;
        public float max;
        public float min;
       
    }
    public class StatsComputer
    {  
        public Metrics CalculateStatistics(List<float> numbers) {
            
            //Implement statistics here
            Metrics stat = new Metrics();
            
            if(numbers.Count==0)
            {
                stat.average = float.NaN;
                stat.min = float.NaN;
                stat.max = float.NaN;
            }
            else
            {
                stat.average = numbers.Average();
                stat.min = numbers.min();
                stat.max = numbers.max();
            }
           
            return stat;
        }  
    }  
}
