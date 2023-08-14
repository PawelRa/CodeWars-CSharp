using System;
using System.Linq;

namespace Merge_two_sorted_arrays_into_one
{
    public class Kata
    {
        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            if (arr1.Length < 1 && arr2.Length < 1) { return new int[] { }; }

            int[] result = arr1.Concat(arr2).ToArray();
            Array.Sort(result);

            return result.Distinct().ToArray();
        }
    }
}
