using System;

namespace Abbreviate_a_Two_Word_Name
{
    public class Kata
    {
        public static string AbbrevName(string name)
        {
            string[] tempArray = name.Split(' ');
            return $"{Char.ToUpper(tempArray[0][0])}.{Char.ToUpper(tempArray[1][0])}";
        }
    }
}
