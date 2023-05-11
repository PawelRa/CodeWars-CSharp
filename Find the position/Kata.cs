using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_position
{
    public class Kata
    {
        public static string Position(char alphabet)
        {
            char[] alphabetArray = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < alphabetArray.Length; i++)
            {
                if (alphabetArray[i] == alphabet)
                {
                    return $"Position of alphabet: {i + 1}";
                }
            }

            return "";
        }
    }
}
