using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Operations
    {
        public static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Mult(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Div(double num1, double num2)
        {
                return num1 / num2;
        }
    }
}
