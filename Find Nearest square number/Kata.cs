namespace CodeWars_CSharp;
using System;

public static class Kata
{
    public static int NearestSq(int n)
    {
        if (n == 1) { return 1; }
        double nSqrt = Math.Sqrt(n);
        if (nSqrt % n == 0) { return n; }

        if ((Math.Ceiling(nSqrt) - nSqrt) > (nSqrt - Math.Floor(nSqrt))) {
            return (int)(Math.Floor(nSqrt) * Math.Floor(nSqrt));
        }
        else
        {
            return (int)(Math.Ceiling(nSqrt)*Math.Ceiling(nSqrt));
        }
    }
}