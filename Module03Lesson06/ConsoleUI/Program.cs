using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This was mostly practice using conditional breakpoints
// Debugging something that is doing random math with no context seems a bit trivial

// Original Inputs and Outputs
// R Method: Input v = -1 output z = -3
// F Method: Input x = -3 Output y = -0.6
// P Method: Input v = -3 Output o = 1.4
// J Method: Input a = -1 Output c = 0.46666666666666662
// W Method: Input e = 0 Output n = 4.4666666666666668
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double i = W(0);
                Console.WriteLine(i);
            }
            catch  (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong.");
            }
            Console.ReadLine();
        }

        private static double W(double e)
        {
            double n = 1;

            n = J(e) + 4;

            return n;
        }

        private static double P(double v)
        {
            double o = 0;

            o = F(v) + 2;

            return o;
        }

        private static double F(double x)
        {
            double y = 0;

            y = x / 5;

            return y;
        }

        private static double J(double a)
        {
            double c = 0;

            a = a - 1;

            c = R(a);

            c = P(c) / 3;

            return c;
        }

        private static double R(double v)
        {
            double z = 5;

            if (v == 0)
            {
                throw new ArgumentException("We cannot divide by zero", "v"); // This is weird, passing in v and returning v
            }
            else
            {
                z = 3 / v;
            }

            return z;
        }
    }
}
