using System;

namespace genericRPG
{
    internal class Player : Character
    {
        private int experience;
        private int Experience { get; set; }

        public Player(string name, int level, string type, int maxHealthPoints) : base(name, level, type, maxHealthPoints)
        {
            this.Experience = 0;
        }        
        public Player() : base()
        {
            this.Experience = 0;

        }
    }
}
