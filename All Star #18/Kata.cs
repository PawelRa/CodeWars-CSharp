namespace All_Star__18
{
    class Kata
    {
        public static int StrCount(string str, char letter)
        {
            int result = 0;

            foreach (char c in str) { 
            if (c == letter)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
