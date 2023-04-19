namespace Miles_per_gallon_to_kilometers_per_liter
{
    public static class Kata
    {
        public static double Converter(int mpg)
        {
            return Math.Round(mpg / (4.54609188 / 1.609344),2);
        }
    }
}
