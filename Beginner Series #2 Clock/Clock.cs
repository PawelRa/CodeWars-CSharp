using System;

namespace Beginner_Series__2_Clock
{
    public static class Clock
    {
        public static int Past(int h, int m, int s)
        {
            return ((h*60*60) + (m*60) + s) * 1000;
        }
    }

}
