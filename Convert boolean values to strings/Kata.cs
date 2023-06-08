using System;
using System.Linq;

namespace Convert_boolean_values_to_strings
{
    public static class Kata
    {
        public static string boolToWord(bool word)
        {
            return word == true ? "Yes" : "No";
        }
    }
}
