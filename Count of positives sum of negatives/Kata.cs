namespace Count_of_positives_sum_of_negatives
{
    public class Kata
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            int[] result = new int[] { 0, 0 };
            if (input == null || input.Length < 1) { return new int[0]; }

            foreach (int i in input)
            {
                if (i > 0) { result[0]++; }
                if (i < 0) { result[1] += i; }
            }

            return result;
        }
    }
}
