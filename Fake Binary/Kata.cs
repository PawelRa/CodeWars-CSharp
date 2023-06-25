namespace Fake_Binary
{
    public class Kata
    {
        public static string FakeBin(string x)
        {
            string result = "";

            foreach (char number in x)
            {
                if (int.Parse(number.ToString()) < 5)
                {
                    result += 0;
                }
                else if (int.Parse(number.ToString()) >= 5)
                {
                    result += 1;
                }
            }
            return result;
        }
    }
}
