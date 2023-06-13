using System;

namespace Capitalization_and_Mutability
{
    public class Kata
    {
        public static string CapitalizeWord(string word)
        {
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0)
                {
                    result += Char.ToUpper(word[i]);
                }
                else
                {
                    result += word[i];
                }
            }

            return result;
        }
    }
}
