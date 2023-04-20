using System;
using System.Linq;

namespace Did_she_say_hallo
{
    public class Kata
    {
        public static bool Validate_hello(string greetings)
        {
            string[] tempArray = greetings.Split(' ');
            string[] helloList = { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc" };

            foreach (string word in tempArray)
            {
                foreach (string helloWord in helloList)
                {
                    if (word.ToLower().Contains(helloWord))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
