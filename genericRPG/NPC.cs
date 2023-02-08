using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericRPG
{
    internal class NPC:Character
    {
        private int awardXP;

        public int AwardXP { get; set; }
        public NPC(string name, int level, string type, int maxHealthPoints) : base(name, level, type, maxHealthPoints) 
        {
            this.awardXP = level * 100;
        }

    }
}
