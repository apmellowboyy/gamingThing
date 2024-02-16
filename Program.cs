using System;

namespace myProject
{
    class myGame
    {
        private string _Game;
        private string _Console;
        private string _Region;

        public myGame()
        {
            _Game = "";
            _Console = "";
            _Region = "";
        }

        public myGame(string Game, string Console, string Region)
        {
            _Game = Game;
            _Console = Console;
            _Region = Region;
        }

        public string Get_Game()
        {
            return _Game;
        }
        public string Get_Console()
        {
            return _Console;
        }
        public string Get_Region()
        {
            return _Region;
        }
        private void Set_Region(string v)
        {
            _Region=v;
        }

        private void Set_Console(string v)
        {
            _Console=v;
        }

        private void Set_Game(string v)
        {
            _Game=v;
        }

       

        static void Main(string[] args)
        {
            myGame game1 = new myGame();
            Console.WriteLine("Please enter the GAME NAME");
            game1.Set_Game(Console.ReadLine());
            Console.WriteLine("Enter the CONSOLE the game is on.");
            game1.Set_Console(Console.ReadLine());
            Console.WriteLine("What REGION is the game from?");
            game1.Set_Region(Console.ReadLine());
            

            myGame game2 = new myGame();
            Console.WriteLine("Please enter the GAME NAME");
            game2.Set_Game(Console.ReadLine());
            Console.WriteLine("Enter the CONSOLE the game is on.");
            game2.Set_Console(Console.ReadLine());
            Console.WriteLine("What REGION is the game from?");
            game2.Set_Region(Console.ReadLine());

            myGame game3 = new myGame();
            game3.Set_Game("Tony Hawk's Pro Skater");
            game3.Set_Console("PS1, N64");
            game3.Set_Region("ALL REGIONS");

            myGame game4 = new myGame();
            game4.Set_Game("Tony Hawk's Pro Skater");
            game4.Set_Console("PS1, N64");
            game4.Set_Region("ALL REGIONS");



            displayMyGames(game1);
            displayMyGames(game2);
            displayMyGames(game3);
            displayMyGames(game4);
        }



        private static void displayMyGames(myGame game)
        {
            Console.WriteLine("Here's all your information.");
            Console.WriteLine($"GAME: {game.Get_Game()}");
            Console.WriteLine($"CONSOLE: {game.Get_Console()}");
            
        }
    }
}