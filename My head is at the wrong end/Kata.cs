namespace My_head_is_at_the_wrong_end
{
    public class Kata
    {
        public static string[] FixTheMeerkat(string[] arr)
        {
            string[] result = new string[arr.Length];
            result[0] = arr[2];
            result[1] = arr[1];
            result[2] = arr[0];
            return result;
        }
    }
}
