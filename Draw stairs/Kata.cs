﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_stairs
{
    public class Kata
    {
        public static string DrawStairs(int n)
        {
            string result = "I";
            if (n == 10) { return result; }
            for (int i = 1; i < n; i++)
            {
                result += "\n";
                result += new String(' ', i);
                result += "I";
            }

            return result;
        }
    }
}
