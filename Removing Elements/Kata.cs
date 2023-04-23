namespace Removing_Elements
{
    public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            if (arr.Length < 3) { return arr; }

            object[] result = new object[arr.Length];
            int empty = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result[i] = arr[i];
                }
                else
                {
                    empty++;
                }
            }
            Console.WriteLine(empty);
            return result;
        }
    }
}
