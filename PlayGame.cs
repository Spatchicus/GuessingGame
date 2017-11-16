using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class PlayGame
    {
        public bool PlayGuessingGame()
        {
            int playerGuess;
            int theAnswer;
            int numberOfGuesses = 1;
            string playerInput;
            bool isNumberGuessed = false;

            Random rng = new Random();
            theAnswer = rng.Next(1, 21);


            Console.WriteLine("Please enter a number between 1 and 20: ");
            do
            {
                Console.Write("Guess {0}: ", numberOfGuesses.ToString());
                playerInput = Console.ReadLine();
                playerGuess = int.Parse(playerInput);


                if (playerGuess > 20 || playerGuess < 1)
                {
                    Console.WriteLine("{0} is not a valid guess, Please try again.", playerGuess);
                }
                else
                {
                    numberOfGuesses++;
                }

                if (playerGuess > theAnswer)
                {
                    Console.WriteLine("Sorry your guess of {0} is higher than the answer", playerGuess);
                }
                else if (playerGuess < theAnswer)
                {
                    Console.WriteLine("Sorry your guess of {0} is lower than the answer", playerGuess);
                }
                else
                {
                    Console.WriteLine("Well done you guessed {0} and the answer was {1}. This took you: {2} guesses", playerGuess, theAnswer, numberOfGuesses - 1);
                    isNumberGuessed = true;
                }

            } while (!isNumberGuessed);

            return isNumberGuessed;
        }

        public bool AskToPlayAgain()
        {
            string again;

            Console.Write("Do you want to play again? (y/n): ");
            again = Console.ReadLine();
            Console.WriteLine();

            if (again[0] == 'y')
            {
                return true;    
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                return false;
            }
        }
    }
}
