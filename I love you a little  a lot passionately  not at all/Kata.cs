using System;

namespace I_love_you_a_little__a_lot_passionately__not_at_all
{
    public class Kata
    {
        public static string HowMuchILoveYou(int nb_petals)
        {
            switch (nb_petals % 6)
            {
                case 1:
                    return "I love you";
                case 2:
                    return "a little";
                case 3:
                    return "a lot";
                case 4:
                    return "passionately";
                case 5:
                    return "madly";
                case 0:
                    return "not at all";
                default:
                    return "-1";
            }
        }
    }
}
