using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class MathShortcuts
    {
        public static double Add(double x, double y)
        {
            //Console.WriteLine($"The value of {x} + {y} = {x + y}");
            double output = x + y;
            return output;
        }

        // Double is good for everything mathwise, INT doesn't do division well, you will have rounding issues.
        public static void AddAll(double[] values)
        {
            double result = 0;
            //values.Sum(x => result += x); // built in method to do this

            foreach ( double v in values )
            {
                result += v;
            }

            Console.WriteLine($"The total is {result}");
        }
    }
}
