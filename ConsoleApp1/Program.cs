using System;

// random number guessing game in c#
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            var rand = new Random();
            int y = rand.Next(0, 100);
            bool flag = false;

            do
            {
                Console.WriteLine("Guess a random number between 1 and 100.");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == y)
                {
                    Console.WriteLine("You win!");
                    flag = true;
                }
                else if (x > y)
                    Console.WriteLine("Sorry, too high.");
                else if (x < y)
                    Console.WriteLine("Sorry, too low.");

            } while (flag == false);

        }

        
    }
}
