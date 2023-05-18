using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_of_index
{
    public static class Kata
    {
        public static List<int> MultipleOfIndex(List<int> xs)
        {
            List<int> result = new List<int>();

            for (int i = 1; i < xs.Count; i++)
            {
                if (xs[i] % i == 0)
                {
                    result.Add(xs[i]);
                }
            }

            return result;
        }
    }
}
