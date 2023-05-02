using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAtoRNAConversion
{
    public class Converter
    {
        public static string dnaToRna(string dna)
        {
            string result = "";

            foreach (char letter  in dna)
            {
                if (letter == 'T')
                {
                    result += "U";
                }  else
                {
                    result += letter;
                }
            }

            return result;
        }
    }
}
