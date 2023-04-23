using System.Collections.Generic;
using System.Linq;

namespace Lario_and_Muigi_Pipe_Problem
{
    public class Fixer
    {
        public static List<int> PipeFix(List<int> numbers)
        {
            int max = numbers.Max();
            int min = numbers.Min();
            List<int> result = new List<int>();

            for (int i = min;  i <= max; i++)
            {
                result.Add(i);
            }
            return result;
        }
    }
}
