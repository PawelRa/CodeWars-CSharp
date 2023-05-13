namespace Find_the_first_non_consecutive_number
{
    public class Kata
    {
        public static object FirstNonConsecutive(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] != 1)
                {
                    return arr[i];
                }
            }

            return null;
        }
    }
}
