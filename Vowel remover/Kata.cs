namespace Vowel_remover
{
    public class Kata
    {
        public static string Shortcut(string input)
        {
            string result = "";
            foreach (char c in input)
            {
                if (char.ToLower(c) == 'a' || char.ToLower(c) == 'e' || char.ToLower(c) == 'i' || char.ToLower(c) == 'o' || char.ToLower(c) == 'u' )
                {
                    continue;
                } else
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
