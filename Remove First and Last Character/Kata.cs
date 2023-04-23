using System;

namespace Remove_First_and_Last_Character
{
    public class Kata
    {
        public static string Remove_char(string s)
        {
            string result = "";
            for (int i = 1; i < s.Length-1; i++)
            {
                result += s[i];
            }

            return result;
        }
    }
}
