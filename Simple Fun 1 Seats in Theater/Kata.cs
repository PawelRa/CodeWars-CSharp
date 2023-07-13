namespace Simple_Fun_1_Seats_in_Theater
{
    public class Kata
    {
        public static int SeatsInTheater(int nCols, int nRows, int col, int row)
        {
            return (nCols - col + 1) * (nRows - row);
        }
    }
}