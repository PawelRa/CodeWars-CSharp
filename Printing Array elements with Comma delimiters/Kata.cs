namespace Printing_Array_elements_with_Comma_delimiters
{
    public class Kata
    {
        public static string PrintArray(object[] array)
        {
            string result = "";

            for (int i = 0; i < array.Length - 1; i++)
            {
                result += array[i].ToString();
                result += ",";
            }
            result += array[array.Length - 1].ToString();

            return result;
        }
    }
}
