﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_it_Up_
{
    public class Kata
    {
        public static string SwitchItUp(int number)
        {
            switch (number)
            {
                case 0:
                    return "Zero";
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                default:
                    return "Nine";
            };
        }
    }
}
