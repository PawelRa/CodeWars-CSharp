using System;

namespace Is_the_string_uppercase
{
    public static class StringExtensions
    {
        public static bool IsUpperCase(this string text)
        {
            foreach (char c in text)
            {
                if (Char.IsLower(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
