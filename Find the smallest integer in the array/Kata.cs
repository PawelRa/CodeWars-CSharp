namespace Find_the_smallest_integer_in_the_array
{
    public class Kata
    {
        public static int FindSmallestInt(int[] args)
        {
            int min = int.MaxValue;
            foreach (int value in args)
            {
                if (value < min) min = value;
            }
            return min;
        }
    }
}
