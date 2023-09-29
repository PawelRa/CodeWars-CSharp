using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_there_a_vowel_in_there
{
    public class Kata
    {
        public static object[] IsVow(object[] a)
        {
            object[] result = new object[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                if (Convert.ToInt32(a[i]) == 117) { result[i] = "u"; }
                else if (Convert.ToInt32(a[i]) == 111) { result[i] = "o"; }
                else if (Convert.ToInt32(a[i]) == 105) { result[i] = "i"; }
                else if (Convert.ToInt32(a[i]) == 101) { result[i] = "e"; }
                else if (Convert.ToInt32(a[i]) == 97) { result[i] = "a"; }
                else { result[i] = a[i]; }
            }
            return result;
        }
    }
}
