namespace Remove_exclamation_marks
{
    public class Kata
    {
        public static string RemoveExclamationMarks(string s)
        {
            if (s.Length < 1) { return ""; }
            string result = "";

            foreach (char c in s)
            {
                if (c == '!')
                {
                    continue;
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
