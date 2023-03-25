namespace Reversed_Words
{
    public class Kata
    {
        public static string ReverseWords(string str)
        {
            if (str.Length == 0) { return ""; }
            if (str.Length == 1) { return str; }

            string[] strToArray = str.Split(" ");
            string result = strToArray[strToArray.Length - 1];
            for (int i = strToArray.Length - 2; i >= 0; i--)
            {
                result += " ";
                result += strToArray[i];
            }
            return result;
        }
    }
}
