using System;

namespace No_zeros_for_heros
{
    public class NoBoring
    {
        public static int NoBoringZeros(int n)
        {
            string tempStringValue = n.ToString();
            int homManyZeros = 1;

            for (int i = tempStringValue.Length - 1; i >= 0; i--)
            {

                if (tempStringValue[i] == '0')
                {
                    homManyZeros *= 10;
                }
                else
                {
                    break;
                }
            }
            return n / homManyZeros;
        }
    }
}
