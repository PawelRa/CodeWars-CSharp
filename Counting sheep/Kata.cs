
namespace Counting_sheep
{
    public static class Kata
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(sheep => sheep);
        }
    }
}
