using System;

namespace genericRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MENU OPTIONS
            //start new game[0]
            //exit game[1]
            Menu mainMenu= new Menu();
            mainMenu.IsActive= true;
            mainMenu.handleInput();

            //Player playerCharacter = new Player("",1, "humanoid", 100);
            //playerCharacter.CreatePlayer();

            //playerCharacter.printInfo();
            Consumable apple = new Consumable("apple", "food", 5, "A shiny apple.");
            NPC george = new NPC("George", 2, "humanoid", 100 );
            Merchant jeff = new Merchant("Jeff", 2, "humanoid", 100);
            Weapon sword = new Weapon("Rusty sword","one handed sword" ,10, "Might have deal some damage over time due to infection.", 10, 0);
            //george.printInfo();
            //jeff.printInfo();
            //george.attack(jeff, sword);
            //jeff.printInfo();
            //george.getHealed(50);
            //george.printInfo();

        }
    }
}
