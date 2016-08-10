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
        int weapon;

        public player(string Player)
        {
            this.PlayerName = Player;
            this.weapon = 50;
        }
    }
}
