using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace genericRPG
{
    internal class Menu
    {
        private int positionIndex;
        private bool isActive;
        private Dictionary<int, string> menuOptions= new Dictionary<int, string>();
        //TODO: dictionary with delegates/methods?

        public int PositionIndex { get; set; }
        public bool IsActive { get; set; }
        public Menu() 
        {
            menuOptions.Add(0, "START NEW GAME");
            menuOptions.Add(1, "OPTIONS");
            menuOptions.Add(2, "EXIT");
        }

        public void printHeader()
        {
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("---------");
        }
        public void printOptions()
        {
            foreach(var menuOption in menuOptions)
            {
                Console.BackgroundColor = PositionIndex == menuOption.Key ? ConsoleColor.White : ConsoleColor.Black;
                Console.ForegroundColor = PositionIndex == menuOption.Key ? ConsoleColor.Black : ConsoleColor.White;
                Console.WriteLine("{0}", menuOption.Value);
                Console.ResetColor();
            }
        }
        public void handleInput()
        {
            Console.WriteLine("input is");
            while (this.IsActive )
            {
                Console.Clear();
                this.printHeader();
                this.printOptions();

                ConsoleKeyInfo input= Console.ReadKey();
                switch (input.Key) 
                {
                    case ConsoleKey.DownArrow:
                        if (this.PositionIndex < menuOptions.Count-1) { this.PositionIndex++; }
                        break;
                    case ConsoleKey.UpArrow:
                        if (this.PositionIndex > 0) { this.PositionIndex--; }
                        break;
                    case ConsoleKey.Enter:
                        //TODO: 
                        break;
                    default: break;
                }


            }
        }
    }
}
