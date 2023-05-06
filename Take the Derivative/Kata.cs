using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_the_Derivative
{
    public class Kata
    {
        public static string Derive(double coefficient, double exponent)
        {
            string result = "";
            result += coefficient * exponent;
            result += "x^";
            result += exponent - 1;

            return result;
        }
    }
}
