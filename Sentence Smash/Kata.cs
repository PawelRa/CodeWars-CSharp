using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Smash
{
    public class Kata
    {
        public static string Smash(string[] words)
        {
            if (words.Length < 1) { return ""; }
            if (words.Length == 1) { return words[0]; }

            string result = "";
            for (int i = 0; i < words.Length - 1; i++)
            {
                result += words[i] + " ";
            }
            result += words[words.Length - 1];

            return result;
        }
    }
}
