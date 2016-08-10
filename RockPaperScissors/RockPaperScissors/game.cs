using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class game
    {
        player playerOne;
        player playerTwo;
        string Player;
        public void RunGame()
        {
            

            Console.WriteLine("Welcome, to a simple game of Rock Paper Scissors. Player One what is your name?:");
            Player = Console.ReadLine();
            this.playerOne = new player(Player);
            Console.WriteLine("Hello, {0} thank you for playing.");
            Console.WriteLine("Welcome, Player Two What is your Name?:");
            Player = Console.ReadLine();
            this.playerTwo = new player(Player);
           
        }
    }
}
