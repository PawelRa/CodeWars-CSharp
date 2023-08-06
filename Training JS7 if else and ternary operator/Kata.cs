namespace Training_JS7_if_else_and_ternary_operator
{
    public class Kata
    {
        public static int SaleHotDogs(int n)
        {
            int price = 0;
            if (n < 5) { price = 100; }
            else if (n < 10) { price = 95; }
            else { price = 90; }

            return n * price;
        }
    }
}
