namespace Reversed_sequence
{
    public static class Kata
    {
        public static int[] ReverseSeq(int n)
        {
            int[] result = new int[n];

            for (int i = n; i > 0; i--)
            {
                result[result.Length - i] = i;
            }

            return result;
        }
    }
}
