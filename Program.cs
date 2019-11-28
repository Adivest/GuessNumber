using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(1, 100);
            int numberOfGuesses = 0;
            bool win = false;

            do
            {
                Console.Write("Guess a number in between 0 and 100: ");
                string s = Console.ReadLine();
                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Too high:guess lower...");
                    Console.ResetColor();
                    numberOfGuesses++;
                }
                else if (i < winNum) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Too lower:guess higher...");
                    Console.ResetColor();
                    numberOfGuesses++;

                }
                else if(i == winNum)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You are right!You win!!!");
                    Console.ResetColor();
                    win = true;
                    numberOfGuesses++;
                }

                Console.WriteLine();



            } while (win == false);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Thank you for playing this game!!!");
            Console.WriteLine("The number of guesses was: {0} ", numberOfGuesses);
            Console.Write("Press any key to finish");
            Console.ResetColor();
            Console.ReadKey(true);


        }
    }
}
