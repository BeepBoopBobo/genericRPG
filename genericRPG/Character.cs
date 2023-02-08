using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericRPG
{
    internal abstract class Character
    {
        protected static int idCnt;

        private int id;
        private int level;
        private string name;
        private string type;
        private int maxHealthPoints;
        private int currHealthPoints;
        private bool alive;
        private List<Item> inventory;


        public int Level { get;set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int MaxHealthPoints { get; set; }
        public int CurrHealthPoints { get; set; }
        public bool Alive { get; set; }

        public Character(string name, int level, string type, int maxHealthPoints)
        {
            this.id = idCnt++;
            this.Name = name;
            this.Level = level;
            this.MaxHealthPoints = maxHealthPoints;
            this.CurrHealthPoints = maxHealthPoints;
            this.Type = type;
            this.Alive = true;
        }
        public void addItemToInv(Item item)
        {
            this.inventory.Add(item);
        }
        public void removeItemFromInv(Item item) 
        {
            this.inventory.Remove(item); 
        }

        public void takeDamage(int damage)
        {
            //TODO: damage negation
            this.CurrHealthPoints-= damage;
            Console.WriteLine("{0} took {1} points of damage.", this.Name, damage);
            if (this.CurrHealthPoints <= 0) 
            {
                this.alive = false;
                Console.WriteLine("{0} died.", this.Name);
            }
        }
        public void getHealed(int heal) 
        {
            this.CurrHealthPoints+= heal;
            if(this.CurrHealthPoints> this.MaxHealthPoints) 
            {
                Console.WriteLine("{0} healed for {1} points.", this.Name, this.CurrHealthPoints-this.MaxHealthPoints);
                this.CurrHealthPoints = this.MaxHealthPoints;
            }
        }

        public void attack( Character target, Weapon weapon)
        {
            Console.WriteLine("{0} attacks {1} with {2}", this.Name, target.Name, weapon.Name);
            target.takeDamage(weapon.Damage);
        }
        public void printInfo()
        {
            Console.WriteLine("\nCharacter '{0}' #{1}, level: {2}\n{3}/{4} HP", this.Name, this.id,this.Level, this.CurrHealthPoints, this.MaxHealthPoints);
        }
        public void getItemFromInventory()
        {
            Console.WriteLine("not yet boi");
        }
        
    }
}
