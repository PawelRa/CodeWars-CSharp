
namespace Counting_sheep
{
    public static class Kata
    {
        public static int CountSheeps(bool[] sheeps)
        {
            int result = 0;
            foreach (bool b in sheeps) 
            { 
            if (b)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
