using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Multiples_of_a_Number
{

    public class Kata
    {
        public static List<int> FindMultiples(int integer, int limit)
        {
           List<int> result = new List<int>();
           for (int i = 1; integer*i<=limit; i++)
            {
                result.Add(integer*i);
                Console.WriteLine(integer * i);
            }

            return result;
        }
    }
}
