namespace Calculate_average
{
    class AverageSolution
    {
        public static double FindAverage(double[] array)
        {
            if (array.Length < 1) return 0;
            double arraySum = 0;
            foreach (var number in array)
            {
                arraySum += number;
            }
            return arraySum / (array.Length);
        }
    }
}
