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
            return $"{coefficient * exponent}x^{exponent--}";
        }
    }
}
