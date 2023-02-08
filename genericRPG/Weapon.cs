using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericRPG
{
    internal class Weapon : Item
    {
        public int Damage { get; set; }
        public int MaxRange { get; set; }


        public Weapon(string name, string type, int value, string description, int damage, int maxRange) : base(name, type, value, description)
        {
            this.Damage= damage;
            this.MaxRange= maxRange;
        }
    }
}
