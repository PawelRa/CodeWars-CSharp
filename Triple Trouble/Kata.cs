using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Trouble
{
    public class Kata
    {
        public static string TripleTrouble(string one, string two, string three)
        {
            string result = "";
            for (int i = 0; i < one.Length; i++)
            {
                result += one[i];
                result += two[i];
                result += three[i];
            }
            return result;
        }
    }
}
