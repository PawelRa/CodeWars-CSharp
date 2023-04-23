using System;

namespace count_sheep
{
    public static class Kata
    {
        public static string CountSheep(int n)
        {
            if (n == 0) { return ""; }
            string result = "";
            for (int i = 1; i<= n; i++)
            {
                result += $"{i} sheep...";
            }

            return result;
        }
    }
}
