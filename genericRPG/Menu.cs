using Microsoft.VisualBasic.FileIO;
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
        private bool isActive;
        //TODO: dictionary with delegates/methods?

        public int PositionIndex { get; set; }
        public bool IsActive { get; set; }


        public Menu() 
        {
        }

        //prints options header
        public void PrintHeader(Dictionary<int, string> headers)
        {
            foreach (var header in headers)
            {
                Console.WriteLine("\t{0}", header.Value);
            }
            Console.WriteLine("\t> navigate by UP and DOWN arrows, confirm choice with ENTER\n");
        }

        //prints out given options with highlighted active item
        public void PrintOptions(Dictionary<int, string> options)
        {

            foreach (var option in options)
            {
                //change background color to white if active
                Console.BackgroundColor = PositionIndex == option.Key ? ConsoleColor.White : ConsoleColor.Black;
                //change text color to black if active
                Console.ForegroundColor = PositionIndex == option.Key ? ConsoleColor.Black : ConsoleColor.White;
                Console.WriteLine("{0}. {1}", option.Key,option.Value);
                Console.ResetColor();
            }
        }

        //handles navigation and selecting items from given options
        //TODO: pass prop with avilable options
        public string HandleMenuOptions(Dictionary<int, string> options, Dictionary<int, string> headers)
        {
            while (this.IsActive)
            {
                Console.Clear();
                this.PrintHeader(headers);
                this.PrintOptions(options);

                ConsoleKeyInfo input= Console.ReadKey();
                switch (input.Key) 
                {
                    case ConsoleKey.DownArrow:
                        if (this.PositionIndex < options.Count-1) { this.PositionIndex++; }
                        break;
                    case ConsoleKey.UpArrow:
                        if (this.PositionIndex > 0) { this.PositionIndex--; }
                        break;
                    case ConsoleKey.Enter:
                        return options.ElementAt(this.PositionIndex).Value;
                    default: 
                        break;
                }
            }
            return "EXIT";
        }
    }
}
