using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Mathematical_Operations
{
    public static class Solution
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '+':
                    return value1 + value2;

                case '-':
                    return value1 - value2;

                case '*':
                    return value1 * value2;

                case '/':
                    return value1 / value2;

            }
            return -1;
        }
    }
}
