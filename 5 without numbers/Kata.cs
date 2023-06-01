using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _5_without_numbers
{
    class Kata
    {
        public static int UnusualFive()
        {
            string[] result = new string[] {"a","b","c","d","e","f"};
            return Array.IndexOf(result,"f");
        }
    }
}
