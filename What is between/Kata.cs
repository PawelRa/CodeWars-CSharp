namespace What_is_between
{
    public class Kata
    {
        public static int[] Between(int a, int b)
        {
            int[] result = new int[b - a + 1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = a + i;
            }
            return result;
        }
    }
}
