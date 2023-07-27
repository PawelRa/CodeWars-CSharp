using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Nth_Even_Number
{
    public class Kata
    {
        public static int NthEven(int n)
        {
            if (n <= 1) return 0;

            return n*2-2;

        }
    }
}
