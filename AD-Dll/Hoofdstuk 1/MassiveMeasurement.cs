﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Dll.Hoofdstuk_1
{
    /// <summary>
    /// A class to measure the average time of a method with a given number of iterations
    /// </summary>
    public static class MassiveMeasurement
    {
        /// <summary>
        /// Measures the average milliseconds
        /// </summary>
        /// <param name="act"></param>
        /// <param name="iterations"></param>
        /// <returns></returns>
        public static double MeasureAverageMilliseconds(Action act, int iterations)
        {
            List<double> results = new List<double>();
            for (int i = 0; i < iterations; i++)
            {
                ActionMeasurement am = new ActionMeasurement();
                results.Add(am.MeasureMilliseconds(act));
            }
            return results.Average();
        }
    }
}
