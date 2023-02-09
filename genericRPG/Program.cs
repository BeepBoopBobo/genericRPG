using System;

namespace genericRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Consumable apple = new Consumable("apple", "food", 5, "A shiny apple.");
            NPC george = new NPC("George", 2, "humanoid", 100);
            Merchant jeff = new Merchant("Jeff", 2, "humanoid", 100);

            Game game = new Game();
            game.Run();
            //TODO: initialize game
            //play until player quits or dies (:


            //MENU OPTIONS
            //start new game[0]
            //exit game[1]


            //mainMenuOptions.Add(0, "START NEW GAME");
            //mainMenuOptions.Add(1, "OPTIONS");
            //mainMenuOptions.Add(2, "EXIT");

            //combatMenuOptions.Add(0, "ATTACK");
            //combatMenuOptions.Add(1, "HEAL");
            //combatMenuOptions.Add(2, "LEAVE");


            //Player playerCharacter = new Player("",1, "humanoid", 100);
            //playerCharacter.CreatePlayer();

            //playerCharacter.printInfo();

            //george.printInfo();
            //jeff.printInfo();
            //george.attack(jeff, sword);
            //jeff.printInfo();
            //george.getHealed(50);
            //george.printInfo();

        }
    }
}
