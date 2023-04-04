namespace Contamination__1__String_
{
    public class Kata
    {
        public static string Contamination(string text, string character)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                result += character;
            }

            return result;
        }
    }
}
