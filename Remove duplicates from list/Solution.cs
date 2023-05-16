using System.Collections.Generic;

namespace Remove_duplicates_from_list
{
    public static class Program
    {
        public static int[] distinct(int[] a)
        {
            List<int> list = new List<int>();
            list.Add(a[0]);
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] != a[i - 1])
                {
                    list.Add(a[i]);
                }
            }
            return list.ToArray();
        }
    }
}
