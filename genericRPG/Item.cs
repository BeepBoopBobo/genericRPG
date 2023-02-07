using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericRPG
{
    internal class Item
    {
        private int id;
        private string name;
        private string type;//consumable, weapon, ...
        //TODO: requirements[]
        private int value;
        private string description;

        public int Id { get; }
        public string Name { get; }
        public string Type { get; }
        public int Value { get; }
        public string Description { get { return description; } }



        // example <'weapon', [damage, range]>
        // example <'consumable', [heal, sideEffect]>
        //maybe resit pres dedicnost
        private Dictionary<string, string> props= new Dictionary<string, string>();

        public void useItem(Item item)
        {
            /*
            TODO: work with props
            */
            Console.Write("{0} used.", this.name);
        }
    }
}
