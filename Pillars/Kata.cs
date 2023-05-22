using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    public static class Kata
    {
        public static int Pillars(int numPill, int dist, int width)
        {
            if (numPill < 2) { return 0; }

            int distance = 0;

            for (int i = 1; i < numPill; i++)
            {
                distance += (dist * 100) + width;
            }

            return distance - width;
        }
    }
}
