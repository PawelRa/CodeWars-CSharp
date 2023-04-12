namespace The_Feast_of_Many_Beasts
{
    public class Kata
    {
        public static bool Feast(string beast, string dish)
        {
            return (beast[0] == dish[0]) && (beast[beast.Length-1] == dish[dish.Length-1]);
        }
    }
}
