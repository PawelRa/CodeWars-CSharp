using System;

namespace Remove_First_and_Last_Character_Part_Two
{
    public static class Kata
    {
        public static string Array(string s)
        {
            if (s.Length < 3) { return null; }
            char[] separators = new char[] { ',', ' ' };
            string[] array = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (array.Length < 2) { return null; }

            string result = "";


            for (int i = 1; i < array.Length - 2; i++)
            {

                result += array[i];
                result += " ";
            }
            result += array[array.Length - 2];

            return result;
        }
    }
}
