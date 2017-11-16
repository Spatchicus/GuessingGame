using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayGame game = new PlayGame();
            bool playAgain = false;

            do
            {
                game.PlayGuessingGame();
                playAgain = game.AskToPlayAgain();

            } while (playAgain);
        }
    }
}


