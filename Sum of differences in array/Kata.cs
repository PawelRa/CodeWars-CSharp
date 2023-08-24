using System.Linq;

namespace Sum_of_differences_in_array
{
    public static class Kata
    {
        public static int SumOfDifferences(int[] arr)
        {
            if (arr == null || arr.Length <=1) return 0;
            arr = arr.OrderByDescending(x => x).ToArray();
            int temp = 0;

            for (int i = 1;i < arr.Length;i++)
            {
                temp += arr[i - 1] - arr[i];
            }

            return temp;
        }
    }
}
