using System;

namespace Parse_nice_int_from_char_problem
{
    public class Kata
    {
        public static int GetAge(string inputString)
        {
            return Convert.ToInt32(new string(inputString[0], 1));
        }
    }
}
