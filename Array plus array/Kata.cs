using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_plus_array
{
    public static class Kata
    {
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            int result = 0;

            foreach (int i in arr1) { result += i; }

            foreach (int i in arr2) { result += i; }

            return result;
        }
    }
}
