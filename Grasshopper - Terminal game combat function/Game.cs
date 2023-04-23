using System;

namespace Grasshopper___Terminal_game_combat_function
{
    public static class Game
    {
        public static float Combat(float health, float damage)
        {
            return health - damage <= 0 ? 0 : health - damage;
        }
    }
}
