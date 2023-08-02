using System;

namespace Convert_to_Binary
{
    public static class Kata
    {
        public static int ToBinary(int n)
        {
            string bin = Convert.ToString(n, 2);
            return Convert.ToInt32(bin);
        }
    }
}