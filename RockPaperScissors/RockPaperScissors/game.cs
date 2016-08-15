using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace RockPaperScissors
{
    public class game
    {
        player playerOne;
        player playerTwo;
        string playerOneName;
        string playerTwoName;
        string weaponType;
        bool runGame;
        public void RunGame()
        {


            Console.WriteLine("Top of the morning to you. Welcome to a simple game of Rock Paper Scissors.");
            Console.WriteLine("How Many Players 1 or 2?");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Excellent! Please, provide me with your name");
                playerOneName = Console.ReadLine();
                this.playerOne = new player(playerOneName);
                Console.WriteLine("Thank you, {0}", playerOneName);
                playerTwoName = "Automatic Rock Paper Scissors Robot";
                this.playerTwo = new player(playerTwoName);

            }
            else
            {
                Console.WriteLine("Excellent! PlayerOne please provide me with your name:");
                playerOneName = Console.ReadLine();
                this.playerOne = new player(playerOneName);
                Console.WriteLine("Hello, {0} thank you for playing.", playerOneName);
                Console.WriteLine("PlayerTwo please provide me with your name?:");
                playerTwoName = Console.ReadLine();
                this.playerTwo = new player(playerTwoName);
                Console.WriteLine("Thank you, {0}", playerTwoName);
                Console.Clear();
            }
            if (playerOne.GetWeaponStatus() == 0)
                {
                this.playerOneTurn();
                }
            if (playerTwo.GetWeaponStatus() == 0 && playerTwoName != "Automatic Rock Paper Scissors Robot")
            {
                this.playerTwoTurn();
            }
            else
            {
                AutomaticAssignWeapon();
            }
            this.results();

        }   



                public void playerOneTurn()
        {
  
            Console.WriteLine("{0} Would you like Rock, Paper or Scissors?:",playerOneName);
            string line = Console.ReadLine();
            weaponType = line.ToLower();
            if (weaponType == "rock" || weaponType == "scissors" || weaponType == "paper")
            {
                playerOne.assignWeapon(weaponType);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("That is not a valid choice. Please, choose again.");
                this.playerOneTurn();
            }    

        }

            public void playerTwoTurn()
        {
            Console.WriteLine("{0} Would you like Rock, Paper or Scissors?:", playerTwoName);
            string line = Console.ReadLine();
            weaponType = line.ToLower();
            if (weaponType == "rock" || weaponType == "scissors" || weaponType == "paper")
            {
                playerTwo.assignWeapon(weaponType);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("That is not a valid choice. Please, choose again.");
                this.playerTwoTurn();
            }
        }

        public void AutomaticAssignWeapon()
        {
            Random random = new Random();
            int weapon = random.Next(1, 4);
            playerTwo.assignWeaponInt(weapon);
        }
        public void results()
        {
            string PlayerOneWeapon;
            string PlayerTwoWeapon;
            string Winner;

            if (playerOne.GetWeaponStatus() == 1)
            {
                PlayerOneWeapon = "Rock";
                if (playerTwo.GetWeaponStatus() == 3)
                {
                    Winner = playerTwoName;
                }
                else if (playerTwo.GetWeaponStatus() == 1)
                {
                    Winner = "tied";
                }
                else
                {
                    Winner = playerOneName;
                }


            }
            else if (playerOne.GetWeaponStatus() == 2)
            {
                PlayerOneWeapon = "Scissors";
                if (playerTwo.GetWeaponStatus() == 3)
                {
                    Winner = playerTwoName;
                }
                else if (playerTwo.GetWeaponStatus() == 2)
                {
                    Winner = "tied";
                }
                else
                {
                    Winner = playerOneName;
                }

            }
            else
            {
                PlayerOneWeapon = "Paper";
                if (playerTwo.GetWeaponStatus() == 3)
                {
                    Winner = playerTwoName;
                }
                else if (playerTwo.GetWeaponStatus() == 3)
                {
                    Winner = "tied";
                }
                else
                {
                    Winner = playerOneName;
                }

            }
        
            if (playerTwo.GetWeaponStatus() == 1)
            {
                PlayerTwoWeapon = "Rock";
            }
            else if (playerTwo.GetWeaponStatus() == 2)
            {
                PlayerTwoWeapon = "Scissors";
            }
            else
            {
                PlayerTwoWeapon = "Paper";
            }


            if (playerOne.GetWeaponStatus() != playerTwo.GetWeaponStatus())
            {
                Console.WriteLine("{0}, you threw {1}. {2}, you threw {3}. {4}, Congratulations, You've Won!", playerOneName, PlayerOneWeapon, playerTwoName, PlayerTwoWeapon, Winner);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You both threw {0}. You Tied!", PlayerOneWeapon);
                Console.ReadLine();
            }
        }


    }
} 