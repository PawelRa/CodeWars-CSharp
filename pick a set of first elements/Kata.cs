using System.Linq;

namespace pick_a_set_of_first_elements
{
    public class Kata
    {
        public static object[] TakeFirstElements(object[] array, int n = 1)
        {
            return array.Skip(0).Take(n).ToArray();
        }
    }
}
