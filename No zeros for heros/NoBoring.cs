using System;

namespace No_zeros_for_heros
{
    public class NoBoring
    {
        public static int NoBoringZeros(int n)
        {
            while (n % 10 == 0)
            {
                n = n / 10;
            }
            return n;
        }
    }
}
