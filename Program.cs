using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessesLimit = 3, guessCount = 0;
            string secretWord = "secret", guess = "";
            string[] enteredGuesses = new string[guessesLimit];
            bool outOfGuesses = false;

            int[,] nummberGrid =
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };

            Console.WriteLine("You have " + guessesLimit + " chances to guess the secret word.");
            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessesLimit && !outOfGuesses)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    enteredGuesses[guessCount] = guess;
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                    Console.WriteLine("You ran out of guesses!");
                }
            }

            if (outOfGuesses)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.Write("You Win! ");
            }

            Console.WriteLine("These are the " + guessCount + " guesses you entered: ");
            for (int loopCount = 0; loopCount < guessesLimit; loopCount++)
            {
                Console.WriteLine(enteredGuesses[loopCount]);
            }

            Console.WriteLine("And just as a novelty, the square of your guessess count is " + GetPower(guessCount, 2) + ".");

            Console.WriteLine("And throwing in a 3x3 2D array of length " + nummberGrid.Length + " as well, here is item in position 2,2: " + nummberGrid[1, 1] + ".");

            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a second number to divide by the previous number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The result of integer " + num1 + " divided by integer " + num2 + " is " + num1 / num2);
            }
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message + "Error! Enter two numbers above 0...");
            //}
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }

        static int GetPower(int baseNum, int powerNum)
        {
            int result = 1;
            for (int i = 0; i < powerNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}

