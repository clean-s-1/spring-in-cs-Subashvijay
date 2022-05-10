using Statistics.Model;
using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers) {
            
            if(numbers == null || numbers.Count == 0)
            {
                return new Stats() {
                    average = Double.NaN,
                    max = Double.NaN,
                    min = Double.NaN,
                };
            }
            var localMax = double.MinValue;
            var localMin = double.MaxValue;
            double sum = 0;
            if (numbers != null) {
                foreach (var num in numbers)
                {
                    if (num > localMax)
                    {
                        localMax = num;
                    }
                    if (num < localMin)
                    {
                        localMin = num;
                    }
                    sum = sum + num;
                }
            }
            
            return new Stats() {
                average = sum / numbers.Count,
                max = localMax,
                min = localMin
            };

            //Implement statistics here
        }
    }

}
