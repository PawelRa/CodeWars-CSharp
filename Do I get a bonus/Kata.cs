namespace Do_I_get_a_bonus
{
    public static class Kata
    {
        public static string bonus_time(int salary, bool bonus)
        {
            return bonus ? $"${salary * 10}" : $"${salary}";
        }
    }
}
