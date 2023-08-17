namespace Are_You_Playing_Banjo
{
    public class Kata
    {
        public static string AreYouPlayingBanjo(string name)
        {
            return char.ToLower(name[0]) == 'r' ? name + " plays banjo" : name + " does not play banjo";
        }
    }
}
