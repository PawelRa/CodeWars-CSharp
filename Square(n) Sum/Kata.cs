namespace Square_n__Sum
{
    public static class Kata
    {
        public static int SquareSum(int[] numbers)
        {
            if (numbers == null) { return 0; }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number * number;
            }
            return sum;
        }
    }
}
