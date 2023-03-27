namespace Cat_Dog_years
{
    public class Dinglemouse
    {
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            int[] result = new int[] { 1, 15, 15 };
            if (humanYears == 1) { return result; }
            
            result[0] = humanYears;
            result[1] = 24 + (humanYears - 2) * 4;
            result[2] = 24 + (humanYears - 2) * 5;

            return result;
        }
    }
}
