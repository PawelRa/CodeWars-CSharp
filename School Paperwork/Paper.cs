﻿using System;

namespace School_Paperwork
{
    public static class Paper
    {
        public static int Paperwork(int n, int m)
        {
            if (n < 0 && m < 0) return 0;
            return n * m > 0 ? n * m : 0;
        }
    }

}
