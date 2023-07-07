namespace Name_on_billboard
{
    public class Kata
    {
        public static double Billboard(string name, double price = 30)
        {
            double result = 0;

            for (int i = 0; i < name.Length; i++)
            {
                result += price;
            }

            return result;
        }
    }
}
