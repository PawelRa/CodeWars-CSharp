namespace Sum_The_Strings
{
    public static class Kata
    {
        public static string StringsSum(string s1, string s2)
        {
            if (s1 == "" &&  s2 == "") { return "0"; }
            if (s1 == "") { return s2; }
            if (s2 == "") { return s1; }

            return $"{Convert.ToInt32(s1)+Convert.ToInt32(s2)}";
        }
    }
}
