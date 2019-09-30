using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("player1");
            Player p2 = new Player("player2");

            Mecanics mecanics = new Mecanics(p1, p2); 

            string[] points = { "player1", "player1", "player2", "player2", "player1", "player1" };
            mecanics.ScoreOps(points, p1, p2);

            Console.ReadKey();
        } 
    }
}
