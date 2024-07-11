using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassPractice
{
    public static class CalculateData
    {
        public static double Add(double x, double y)
        {
            double output = x + y;
            return output;
        }

        public static double Subtract(double x, double y) 
        {
            double output = x - y;
            return output;
        }

        public static double Divide(double x, double y) 
        { 
            double output = (x / y);
            return output;
        }

        public static double Multiply(double x, double y) 
        { 
            double output = (x * y);    
            return output;
        }

        //public static int Power(int pX, int pY)  // Apparently '^' is the bitwise XOR operator 
        //{ 
        //    int output = (pX) ^ pY;
        //    return output;
        //}

        public static int Power(int pX, int pY)
        {
            int output = (int)Math.Pow(pX, pY);
            return output;
        }


    }
}
