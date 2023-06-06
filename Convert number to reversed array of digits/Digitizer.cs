using System;
using System.Collections.Generic;

namespace Convert_number_to_reversed_array_of_digits
{
    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            string nString = n.ToString();

            long[] result = new long[nString.Length];
            for (int i = nString.Length - 1; i >= 0; i--)
            {
                result[nString.Length - i - 1] = (long)Char.GetNumericValue(nString[i]);
            }

            return result;
        }
    }
}
