using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twice_as_old
{
    public class TwiceAsOldSolution
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            for (int i = 0; (sonYears + i) * 2 <= dadYears + i; i++)
            {
                Console.WriteLine(i);
                if ((sonYears + i) * 2 == dadYears + i)
                {
                    return i;
                }
            }

            for (int i = 0; (sonYears + i) * 2 >= dadYears + i; i--)
            {

                if ((sonYears + i) * 2 == dadYears + i)
                {
                    return i * (-1);
                }
            }

            return -1;
        }
    }
}
