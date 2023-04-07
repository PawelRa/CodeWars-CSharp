using System;

namespace The_highest_profit_wins
{
    public class MinMax
    {
        public static int[] minMax(int[] lst)
        {
            if (lst.Length == 1) { return new int[] { lst[0], lst[0] }; }
            
            int[] result = {int.MaxValue,int.MinValue};
            foreach (int number in lst)
            {
                if (number < result[0]) { result[0] = number; }
                if (number > result[1]) { result[1] = number; }
            }

            return result;
        }
    }
}
