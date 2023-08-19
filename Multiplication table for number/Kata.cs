namespace Multiplication_table_for_number
{
    public static class Kata
    {
        public static string MultiTable(int number)
        {
            string result = "";
            for (int i = 1; i < 10; i++)
            {
                result += $"{i} * {number} = {i * number}\n";
            }
            result += $"10 * {number} = {10 * number}";

            return result;
        }
    }
}
