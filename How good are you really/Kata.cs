using System.Linq;

namespace How_good_are_you_really
{
    public class Kata
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return (ClassPoints.Average() + YourPoints) / ClassPoints.Length + 1 < YourPoints;
        }
    }
}
