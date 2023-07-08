using System;
using System.Collections.Generic;
using System.Linq;

namespace Removing_Elements
{
    public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {

            var list = new List<object>();
            for (int i = 0; i < arr.Count(); i += 2)
            {
                list.Add(arr[i]);
            }
            return list.ToArray();
        }
    }
}
