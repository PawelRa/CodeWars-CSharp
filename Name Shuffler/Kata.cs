using System;

namespace Name_Shuffler
{
    public class Kata
    {
        public static string NameShuffler(string str)
        {
            string[] strArray = str.Split(" ");
            string result = "";

            result += strArray[1];
            result += " ";
            result += strArray[0];

            return result;
        }
    }
}
