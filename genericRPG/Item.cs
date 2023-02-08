using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericRPG
{
    internal abstract class Item
    {
        protected static int idCnt;

        private int id;
        private string name;
        private string type;//consumable, weapon, ...
        //TODO: requirements[]
        private int value;
        private string description;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }

        public Item(string name, string type, int value, string description)
        {
            this.Id = idCnt++;
            this.Name = name;
            this.Type = type;
            this.Value = value;
            this.Description = description;

        }

        // example <'weapon', [damage, range]>
        // example <'consumable', [heal, sideEffect]>
        //maybe resit pres dedicnost
        private Dictionary<string, string> props= new Dictionary<string, string>();

        public virtual void useItem(Item item)
        {
            /*
            TODO: work with props
            */
            Console.Write("{0} used.", this.name);
        }

        public void printInfo()
        {
            Console.WriteLine("name: {0}, id: {1}, desc: {2}", this.name, this.id, this.description);
        }
    }
}
