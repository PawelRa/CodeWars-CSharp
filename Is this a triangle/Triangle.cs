namespace Is_this_a_triangle
{
    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                if (b + c >= a) return true;
            }
            else if (b >= a && b >= c)
            {
                if (c + a >= b) return true;
            }
            else if (c >= a && c >= b)
            {
                if (b + a >= c) { return true; }
            }
            return false;
        }
    }
}
