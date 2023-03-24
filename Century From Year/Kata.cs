namespace Century_From_Year;
using System;

public static class Kata
{
    public static int СenturyFromYear(int year)
    {
        if (year % 100 == 0) { return year / 100; }

        return (int)Math.Floor((double)(year / 100)) + 1;
    }
}
