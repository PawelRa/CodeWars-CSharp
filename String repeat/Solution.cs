namespace String_repeat;

public static class Program
{
    public static string RepeatStr(int n, string s)
    {
        if (n < 1) return "";

        string result = "";
        for (int i = 0; i < n; i++)
        {
            result += s;
        }

        return result;
    }
}
