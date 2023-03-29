using System.Numerics;

namespace Powers_of_2
{
    public class Kata
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            List<BigInteger> result = new List<BigInteger>();

            for (int i = 0; i <= n; i++)
            {
                result.Add((BigInteger)Math.Pow(2, i));
            }

            return result.ToArray();
        }
    }
}
