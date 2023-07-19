using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Are_they_opposite
{
    public class Kata
    {
        public static bool IsOpposite(string s1, string s2)
        {
            for(int i = 0; i < s1.Length; i++)
            {
                if ((Char.IsLower(s1[i])&& Char.IsLower(s2[i])) || (Char.IsUpper(s1[i]) && Char.IsUpper(s2[i])))
                {
                    return false;
                }
            }



            return true;
        }
    }
}
