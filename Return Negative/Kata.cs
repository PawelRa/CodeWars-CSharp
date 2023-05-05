using System;

namespace Return_Negative
{
    public static class Kata
    {
        public static int MakeNegative(int number)
        {
            return number > 0 ? number * (-1) : number;
        }
    }
}
