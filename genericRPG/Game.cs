using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericRPG
{
    internal class Game
    {
        public bool IsRunning { get; set; }
        //TODO move game logic here
        public Player player = new Player();
        public Enemy enemy;
        public Menu menu = new Menu();

        private Dictionary<int, string> MainMenuOptions = new Dictionary<int, string>();
        private Dictionary<int, string> CombatMenuOptions = new Dictionary<int, string>();
        private Dictionary<int, string> MainMenuHeaders = new Dictionary<int, string>();
        private Dictionary<int, string> CombatMenuHeaders = new Dictionary<int, string>();

        Weapon sword = new Weapon("Rusty sword", "one handed sword", 10, "Might have deal some damage over time due to infection.", 10, 0);


        public Game() 
        {
            IsRunning = true;

            MainMenuHeaders.Add(0, "MAIN MENU");

            MainMenuOptions.Add(0, "START NEW GAME");
            MainMenuOptions.Add(1, "OPTIONS");
            MainMenuOptions.Add(2, "EXIT");


            CombatMenuOptions.Add(0, "ATTACK");
            CombatMenuOptions.Add(1, "HEAL");
            CombatMenuOptions.Add(2, "LEAVE");
        }
        public Enemy GetEnemy()
        {
            return new Enemy("Koksa", 2, "humanoid", 50);
        }



        public void Run()
        {
            MainMenuRender();
            enemy=GetEnemy();
            Console.Clear();
            Console.WriteLine("A wild {0} appeared, prepare to fight!", enemy.Name);
            Console.ReadKey();

            while (IsRunning)
            {
                CombatMenuHeaders.Clear();
                CombatMenuHeaders.Add(0, "Name:" + player.Name + ", HP: " + player.CurrHealthPoints + "/" + player.MaxHealthPoints);
                CombatMenuHeaders.Add(1, "Name:" + enemy.Name + ", HP: " + enemy.CurrHealthPoints + "/" + enemy.MaxHealthPoints);
                //TODO make a combat handler
                CombatMenuRender();
            }
        }

        public void CombatMenuRender()
        {
            if (enemy.Alive == false)
            {
                GameWonRender();
                this.IsRunning = false;

            }
            else
            {
                string response = menu.HandleMenuOptions(this.CombatMenuOptions, this.CombatMenuHeaders);
                switch (response)
                {
                    case "ATTACK":
                        Console.Clear();
                        player.Attack(this.enemy, this.sword);
                        player.PrintInfo();
                        enemy.PrintInfo();
                        Console.ReadKey();
                        break;
                    case "HEAL":
                        Console.Clear();
                        player.GetHealed(15);
                        break;
                    case "LEAVE":
                        this.GameLostRender();
                        this.IsRunning = false;
                        break;
                    default:
                        break;
                }
            }

        }
        public void GameLostRender()
        {
            Console.Clear();

            Console.WriteLine("YOU DECIDED FIGHTING IS NOT WORTH YOUR TIME.");
        }        
        public void GameWonRender()
        {
            Console.Clear();
            Console.WriteLine("CONGRATULATIONS, {0} WAS DEFEATED!", this.enemy.Name);
        }
        public void CharCreationRender()
        {
            Console.Clear();
            Console.WriteLine("Enter name of your character:");
            player.Name = Console.ReadLine();
        }

        public void MainMenuRender()
        {
            string response;
            menu.IsActive = true;
            response = menu.HandleMenuOptions(this.MainMenuOptions, this.MainMenuHeaders);

            switch (response) 
                {
                case "START NEW GAME":
                    CharCreationRender();
                    break;
                case "OPTIONS":
                    break;
                case "EXIT":
                    IsRunning= false;
                    break;
                default:
                    break;
                }
                
                Console.WriteLine(response);
        }
        //game options


        //Menu mainMenu = new Menu();
        //mainMenu.IsActive= true;
        //mainMenu.handleInput();
    }
}
