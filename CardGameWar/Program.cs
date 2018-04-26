using CardGameWar.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTurnCount = 0;
            int finiteGameCount = 0;
            for (int i = 0; i < 1000; i++)
            {
                //Create game
                Game game = new Game("Alice", "Bob");
                while (!game.IsEndOfGame())
                {
                    game.PlayTurn();
                }

                if (game.TurnCount < 1000)
                {
                    totalTurnCount += game.TurnCount;
                    finiteGameCount++;
                }
            }

            double avgTurn = (double)totalTurnCount / (double)finiteGameCount;

            Console.WriteLine(finiteGameCount + " finite games with an average of " + Math.Round(avgTurn, 2) + " turns per game.");

            Console.Read();
        }
    }
}
