using System;

namespace Super_Duper_Easy
{
    public class Kata
    {
        public static string Problem(String a)
        {
            if (a.Length < 1) { return "Error"; }
            foreach (char item in a)
            {
                if (!char.IsDigit(item) && item != '.')
                {
                    return "Error";
                }
            }

            double number = (double)Convert.ToDouble(a);

            return Convert.ToString(number * 50 + 6);
        }
    }
}
