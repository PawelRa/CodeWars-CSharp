using System.Collections.Generic;

namespace Reverse_List_Order
{
    public class Kata
    {
        public static List<int> ReverseList(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (int el in list)
            {
                result.Insert(0, el);
            }
            return result;
        }
    }
}
