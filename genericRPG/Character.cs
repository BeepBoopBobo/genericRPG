﻿using System;
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
        public Character()
        {
            this.Level = 0;
            this.Name = "";
            this.Type = "";
            this.MaxHealthPoints = 100;
            this.CurrHealthPoints = 100;
            this.Alive = true;
        }
        public void AddItemToInv(Item item)
        {
            this.inventory.Add(item);
        }
        public void RemoveItemFromInv(Item item) 
        {
            if(this.inventory.IndexOf(item) != -1)
            {
                this.inventory.Remove(item);
                Console.WriteLine("{0} removed from {1}'s inventory.", item.Name, this.Name);
            }
            else
            {
                Console.WriteLine("{0} is not in {1}'s inventory.", item.Name, this.Name);
            }
        }

        public void TakeDamage(int damage)
        {
            //TODO: damage negation
            this.CurrHealthPoints-= damage;
            Console.WriteLine("{0} took {1} points of damage.", this.Name, damage);
            if (this.CurrHealthPoints <= 0) 
            {
                this.Alive = false;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} died.", this.Name);
                Console.BackgroundColor = ConsoleColor.Black;

            }
        }
        public void GetHealed(int heal) 
        {
            this.CurrHealthPoints+= heal;
            if(this.CurrHealthPoints> this.MaxHealthPoints) 
            {
                Console.WriteLine("{0} healed for {1} points.", this.Name, this.CurrHealthPoints-this.MaxHealthPoints);
                this.CurrHealthPoints = this.MaxHealthPoints;
            }
            else
            {
                Console.WriteLine("{0} is at full health already.", this.Name);
            }
        }

        public void Attack( Character target, Weapon weapon)
        {
            Console.WriteLine("{0} attacks {1} with {2}", this.Name, target.Name, weapon.Name);
            target.TakeDamage(weapon.Damage);
        }
        public void PrintInfo()
        {
            Console.WriteLine("\nCharacter '{0}' #{1}, level: {2}\n{3}/{4} HP", this.Name, this.id, this.Level, this.CurrHealthPoints, this.MaxHealthPoints);
        }
        public void GetItemFromInventory()
        {
            Console.WriteLine("not yet boi");
        }
        
    }
}
