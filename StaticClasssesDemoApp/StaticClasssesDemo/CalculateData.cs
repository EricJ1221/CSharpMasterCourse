using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasssesDemo
{
    public class CalculateData
    {
        public static int MyAge; // this number would be stored for the entire life of the application, this is why we don't typically store data in a static class
                                 // takes up memory and storage, will cause memory footprint to grow larger over time, it can also step on toes (overwriting other variables)
        
        public static double Add(double x, double y)
        {
            double output = x + y;

            return output;
        }
    }
}
