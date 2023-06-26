using System;

namespace Sum_of_Multiples
{
    public class Kata
    {


        public static int SumMul(int n, int m)
        {
            if (n <= 0 || m <= n)
            {
                throw new ArgumentException();
            }

            int result = 0;

            for (int i = n; i < m; i += n)
            {
                result += i;
            }

            return result;
        }
    }
}
