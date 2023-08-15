using System;

namespace Alan_Partridge_II___Apple_Turnover
{
    public class Kata
    {
        public static string Apple(object n)
        {
            int temperature = 0;

            if (n.GetType() == typeof(string))
            {

                temperature = Convert.ToInt32(n.ToString());
            }
            else if (n.GetType() == typeof(int))
            {
                temperature = (int)n;
            }

            return temperature * temperature > 1000 ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
        }
    }
}
