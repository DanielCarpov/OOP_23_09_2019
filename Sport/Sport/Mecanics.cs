using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    class Mecanics
    {
        private Player p1;
        private Player p2;

        public Mecanics(Player p1, Player p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void ScoreOps(string[] comb, Player p1, Player p2)
        {
            IGame game = new TwoPlayersGame(p1, p2);

            foreach(string p in comb)
            {
                game.Inc(1, p);
                TennisScoreImplementation(p1.score, p2.score);
            }
        }
        public void TennisScoreImplementation(int p1, int p2)
        {
            string score = "";
            var tempScore = 0;
            if (p1 == p2)
            {
                switch (p1)
                {
                    case 0:
                        score = "Love-All";
                        break;
                    case 1:
                        score = "Fifteen-All";
                        break;
                    case 2:
                        score = "Thirty-All";
                        break;
                    default:
                        score = "Deuce";
                        break;

                }
            }
            else if (p1 >= 4 || p2 >= 4)
            {
                var minusResult = p1 - p2;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = p1;
                    else { score += "-"; tempScore = p2; }
                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            Console.WriteLine("Score: " + score);
        }

    }
}
