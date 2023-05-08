using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_amount_of_points
{
    public static class Kata
    {
        public static int TotalPoints(string[] games)
        {
            int score = 0;

            for (int i = 0; i < games.Length; i++)
            {
                if (games[i][0] > games[i][2])
                {
                    score += 3;
                }
                else if (games[i][0] == games[i][2])
                {
                    score += 1;
                }
            }

            return score;
        }
    }
}
