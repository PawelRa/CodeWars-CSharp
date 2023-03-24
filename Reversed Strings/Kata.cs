using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_Strings
{
    public static class Kata
    {
        public static string Solution(string str)
        {
            return new string(str.ToArray().Reverse().ToArray());
        }
    }
}
