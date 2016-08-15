using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class player
    {
        string PlayerName;
        int Weapon;
        bool playerTurn;

        public player(string Player)
        {
            this.PlayerName = Player;
            this.Weapon = 0;
            this.playerTurn = true;
        }
        public void assignWeapon(string weaponType)
        {
            switch (weaponType)
            {
                case "rock":
                    { this.Weapon = 1; }
                    break;
                case "scissors":
                    { this.Weapon = 2; }
                    break;
                case "paper":
                    { this.Weapon = 3; }
                    break;
                default:
                    { this.Weapon = 0; }
                    break;
            }
        }
        public void assignWeaponInt(int weaponType)
        {
            switch (weaponType)
            {
                case 1:
                    { this.Weapon = 1; }
                    break;
                case 2:
                    { this.Weapon = 2; }
                    break;
                case 3:
                    { this.Weapon = 3; }
                    break;
                default:
                    { this.Weapon = 0; }
                    break;
            }
        }
        public int GetWeaponStatus()
            {
            return this.Weapon;
            }
        public string GetPlayerName()
            {
            return this.PlayerName;
            }

    }
}

