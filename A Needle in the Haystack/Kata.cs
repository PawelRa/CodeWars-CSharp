using System;

namespace A_Needle_in_the_Haystack
{
    public class Kata
    {
        public static string FindNeedle(object[] haystack)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] is string && haystack[i] == "needle")
                {
                    return "found the needle at position " + i;
                }
            }

            return "bad";
        }
    }
}
