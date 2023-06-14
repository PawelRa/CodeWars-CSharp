namespace Grasshopper___If_else_syntax_debug
{
    public class Player
    {
        private int health = 100;
        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                health = value;
            }
        }

        public bool CheckAlive()
        {
            if
            (this.Health <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
