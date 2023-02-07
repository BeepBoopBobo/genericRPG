using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericRPG
{
    internal class Enemy
    {
        private int id;
        private string name;
        private int maxHealthPoints;
        private int currHealthPoints;
        private int damage;
        private bool alive;
        private object[] inventory= new object[4];


        public int MaxHealthPoints { get { return maxHealthPoints; } }
        public int CurrentHealthPoints { get { return currHealthPoints; } }
        public int Damage { get { return damage;} }
        public object Inventory { get { return inventory; } }

        Enemy(int maxHealthPoints, int damage, object[] inventory)
        {
            this.damage = damage;
            this.maxHealthPoints = maxHealthPoints;
            this.currHealthPoints=  maxHealthPoints;
            this.inventory = inventory;
            this.alive = true;
        }


        public void changeHealthPoints(int healthPoints){
            this.currHealthPoints += healthPoints;
            if(healthPoints > 0)
            {
                Console.WriteLine("{0} healed for {1} points.", this.name, healthPoints);
            }else if(healthPoints<0){
                Console.WriteLine("{0} took {1} points of damage.", this.name, healthPoints);
            }
            else
            {
                Console.WriteLine("{0}'s health remained the same.", this.name);
            }

            if (this.currHealthPoints <= 0)
            {
                this.alive = false;
                Console.WriteLine("{0} died.", this.name);
            }
        }

        public object getItemFromInventory(int index)
        {
            Console.WriteLine("Looted {0}.", this.inventory[index]);
            return inventory[index];
        }
    }
}
