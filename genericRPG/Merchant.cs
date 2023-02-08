using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericRPG
{
    internal class Merchant:NPC
    {
        public Merchant(string name, int level, string type, int maxHealthPoints) : base(name,level, type, maxHealthPoints) { }
        public void buyItemFromPlayer() { 

        }
        public void sellItemToPlayer() {
            //TODO return item
        }
    }
}
