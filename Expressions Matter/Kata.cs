using System.Linq;

namespace Expressions_Matter
{
    public class Kata
    {
        public static int ExpressionsMatter(int a, int b, int c)
        {
            
            int[] result = new int[] { a + b + c, a + b * c, (a + b) * c, a * b * c, a * b + c, a * (b + c) };
            
            return result.Max();
        }
    }
}
