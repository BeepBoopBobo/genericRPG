using System;

namespace genericRPG
{
    internal class Player : Character
    {
        public Player(string name, int level, string type, int maxHealthPoints) : base(name, level, type, maxHealthPoints)
        {
        }
  
        public Player CreatePlayer()
        {
            Console.WriteLine("Enter name of your character:");
            
            this.Name= Console.ReadLine();
            
            return this;
            //Console.WriteLine("");
            //Console.ReadLine();
            //Console.WriteLine("",);
            //Console.ReadLine();
        }
    }
}
