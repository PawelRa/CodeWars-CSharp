using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_n_divisible_by_x_and_y
{
    public class DivisibleNb
    {
        public static bool IsDivisible(int n, int x, int y)
        {
            return (n % x == 0 && n % y == 0);
        }
    }
}