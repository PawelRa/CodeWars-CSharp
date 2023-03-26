namespace Add_Length
{
    public class Kata
    {
        public static string[] AddLength(string str)
        {
            string[] strArray = str.Split(" ");
            string[] result = new string[strArray.Length];
            for (int i = 0; i < strArray.Length;i++)
            {
                result[i] = strArray[i] + " " + strArray[i].Length;
            } 
            return result;
        }
    }
}
