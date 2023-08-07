using System;

namespace Never_visit_a
{
    public class Kata
    {
        public static string SubtractSum(int number)
        {
            string[] fruits = new string[] {"zero","kiwi", "pear","kiwi","banana","melon","banana","melon","pineapple","apple","pineapple","cucumber","pineapple","cucumber",
                "orange","grape","orange","grape","apple","grape","cherry","pear","cherry","pear","kiwi","banana","kiwi","apple","melon","banana","melon","pineapple","melon",
                "pineapple","cucumber","orange","apple","orange","grape","orange","grape","cherry","pear","cherry","pear","apple","pear","kiwi","banana","kiwi","banana",
                "melon","pineapple","melon","apple","cucumber","pineapple","cucumber","orange","cucumber","orange","grape","cherry","apple","cherry","pear","cherry","pear",
                "kiwi","pear","kiwi","banana","apple","banana","melon","pineapple","melon","pineapple","cucumber","pineapple","cucumber","apple","grape","orange","grape",
                "cherry","grape","cherry","pear","cherry","apple","kiwi","banana","kiwi","banana","melon","banana","melon","pineapple","apple","pineapple"};

            do
            {
                int tempSum = 0;
                string numberToString = number.ToString();
                foreach (char n in numberToString)
                {
                    tempSum += Convert.ToInt32(new string(n, 1));

                }
                number -= tempSum;
            } while (number > 100);

            return fruits[number];
        }
    }
}
