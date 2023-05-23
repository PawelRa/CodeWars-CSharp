using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latin_Squares
{
    public class LatinSquare
    {
        public static int[][] MakeLatinSquare(int n)
        {
            // Make all rows and columns 1, 2, ..., n
            int[][] latinSquare = new int[n][];
            for (int i = 0; i < n; i++)
            {
                latinSquare[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    latinSquare[i][j] = j + 1 % n + 1;
                }
            }

            // Make changes
            // Modify the Latin square if needed

            return latinSquare;
        }
    }
}
