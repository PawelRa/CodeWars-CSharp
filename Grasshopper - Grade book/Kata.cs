namespace Grasshopper___Grade_book
{
    public class Kata
    {
        public static char GetGrade(int s1, int s2, int s3)
        {
            int gradeSum = (s1 + s2 + s3) / 3;

            if (gradeSum >= 90) { return 'A'; }
            else if (gradeSum >= 80) { return 'B'; }
            else if (gradeSum >= 70) { return 'C'; }
            else if (gradeSum >= 60) { return 'D'; }
            else { return 'F'; }

        }
    }
}
