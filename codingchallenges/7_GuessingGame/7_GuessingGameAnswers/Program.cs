using System;
using System.Collections.Generic;

namespace _7_GuessingGameChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool playAgain = true;
            do
            {
                // declare needed variables here.
                int userGuess;
                int randomNumber = GetRandomNumber();
                int result;
                int numGuesses = 0;
                List<int> guesses = new List<int>();

                do
                {
                    System.Console.WriteLine($"\n\n\tPlease enter a number from 0 to 100.\n I'll tell you if it's higher, lower, or the same as my random number.");
                    userGuess = GetUsersGuess();
                    result = CompareNums(randomNumber, userGuess);
                    if (result == -1)
                    {
                        System.Console.WriteLine($"Your guess, {userGuess}, is too high.");
                        numGuesses++;
                    }
                    else if (result == 1)
                    {
                        System.Console.WriteLine($"Your guess, {userGuess}, is too low.");
                        numGuesses++;
                    }
                    else
                    {
                        System.Console.WriteLine($"That guess was correct! Congratulations, you win!");
                        break;
                    }
                    guesses.Add(userGuess);

                    foreach (int x in guesses)
                    {
                        Console.Write($"{x}, ");
                    }
                } while (numGuesses < 10);

                if (numGuesses == 10)
                {
                    System.Console.WriteLine($"\n\n\t\tYou've used up your guesses.\n\n");
                }

                playAgain = PlayGameAgain();
            } while (playAgain == true);
        }

        /// <summary>
        /// This method returns a randomly chosen number between 1 and 100, inclusive.
        /// </summary>
        /// <returns></returns>
        public static int GetRandomNumber()
        {
            //throw new NotImplementedException();
            Random rand = new Random();
            return rand.Next(101);
        }

        /// <summary>
        /// This method gets input from the user, 
        /// verifies that the input is valid and 
        /// returns an int.
        /// </summary>
        /// <returns></returns>
        public static int GetUsersGuess()
        {
            //throw new NotImplementedException();
            int outVar;
            System.Console.WriteLine($"Please enter an integer from 0 to 100");
            string guess = Console.ReadLine().Trim();
            bool result = Int32.TryParse(guess, out outVar);
            while (result == false || outVar < 0 || outVar > 100)
            {
                System.Console.WriteLine($"WARNING: \"{guess}\" is not an integer from 0 to 100. Please enter an integer from 0 to 100");
                guess = Console.ReadLine();
                result = Int32.TryParse(guess, out outVar);
            }
            return outVar;
        }

        /// <summary>
        /// This method will has two int parameters.
        /// It will:
        /// 1) compare the first number to the second number
        /// 2) return -1 if the first number is less than the second number
        /// 3) return 0 if the numbers are equal
        /// 4) return 1 if the first number is greater than the second number
        /// </summary>
        /// <param name="randomNum"></param>
        /// <param name="guess"></param>
        /// <returns></returns>
        public static int CompareNums(int randomNum, int guess)
        {
            // throw new NotImplementedException();
            if (randomNum < guess)
            {
                return -1;
            }
            else if (randomNum > guess)
            {
                return 1;
            }
            else return 0;
        }

        public static bool PlayGameAgain()
        {
            // throw new NotImplementedException();
            System.Console.WriteLine($"\nWould you like to play again?\n\t Enter 1 to play again.\n\t Enter 0 to Quit.");
            string playAgain = Console.ReadLine().Trim();
            int outVar;
            bool result = Int32.TryParse(playAgain, out outVar);
            while (result == false)
            {
                System.Console.WriteLine($"WARNING: \"{playAgain}\" is not a 1 or a 0. Please enter a 1 or a 0");
                playAgain = Console.ReadLine();
                result = Int32.TryParse(playAgain, out outVar);
            }

            if (outVar == 1)
            {
                return true;
            }
            else return false;
        }
    }
}
