namespace Reduce_but_Grow
{
    public class Kata
    {
        public static int Grow(int[] x)
        {
            int result = 1;

            foreach (int i in x)
            {
                result *= i;
            }

            return result;
        }
    }
}
