using System;

namespace Check_same_case
{
    public class Kata
    {
        public static int SameCase(char a, char b)
        {
            if (!Char.IsLetter(a) || !Char.IsLetter(b)) { return -1; };

            if ((Char.IsUpper(a) && Char.IsUpper(b)) || (Char.IsLower(a) && Char.IsLower(b))) { return 1; }

            return 0;
        }
    }
}
