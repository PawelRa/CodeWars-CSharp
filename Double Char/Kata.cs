﻿namespace Double_Char
{
    public class Kata
    {
        public static string DoubleChar(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                result += c;
                result += c;
            }
            return result;
        }
    }
}
