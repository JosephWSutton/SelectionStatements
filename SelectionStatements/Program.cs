using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("Enter your guess and we'll do the rest!");

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;

            do
            {
                userInput = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your guess and we'll do the rest!");
                if (userInput > favNumber)
                {
                    Console.WriteLine("Your guess is too high!");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Your guess is too low!");
                }
                else
                {
                    Console.WriteLine("Nevermind");
                }

            } while (userInput != favNumber);
        }
    }
}
