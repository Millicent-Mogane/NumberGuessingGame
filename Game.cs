using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Note to myself: Always write comments

            //Generate a random number between a set minimum and maximum
            Random random = new Random();

            //Variable declaration
            bool playAgain = true; //Determines if the user wants to play again
            int min = 1; //Min value for random number
            int max = 100; //Max number for random number
            int guess; //stores the user's guess
            int number; //Stores the correct randomly generated number
            int guesses; //Counts guesses the user makes
            string response;

            // Prompt for player's name
            Console.WriteLine("Enter your name:");
            string playerName = Console.ReadLine();

            //Main game loop that repeats if the user wants to play again
            while (playAgain)
            {
                guess = 0; //Reset guess for a new round
                guesses = 0; //Reset guess count
                response = ""; //Reset response input
                number = random.Next(min, max + 1); //New random number

                //Loop that continues until the user guesses the correct number
                while (guess != number)
                {
                    // Prompt user to guess a number within the range
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");

                    //Read and convert the user input into an integer
                    guess = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Guess: " + guess); //Display guesses

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!"); //Display a hint
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!"); //Display a hint
                    }
                    guesses++; //Increment guesses by 1 after each guess
                }

                Console.WriteLine("Number: " + number); //Reveal the correct number
                Console.WriteLine("YOU WIN!"); // Celebrate the win
                Console.WriteLine($"Great job, {playerName}! You guessed the number in {guesses} tries!"); // 👏

                // Ask user if they want to play again
                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                // Update playAgain based on the user's response
                playAgain = response == "Y";
            }

            //Final message after the user chooses not to play again
            Console.WriteLine($"Thanks for playing, {playerName}!");

            //Prevents console from closing immediately
            Console.ReadKey();
        }
    }
}
