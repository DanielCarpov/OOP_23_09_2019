using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    class TwoPlayersGame : IGame
    {
        private Player p1;
        private Player p2;

        public TwoPlayersGame(Player p1, Player p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public void Inc(int a, string p)
        {
            if (p == p1.name)
                p1.score += a;
            else if (p == p2.name)
                p2.score += a;
            else
                Console.WriteLine("Unused player name (" + p + ") in winning combination string");
        }
    }
}
