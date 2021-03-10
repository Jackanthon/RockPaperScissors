using System;

namespace Rockpaper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");


            do
            {
                for (int i = 0; i < 2; i++)
                {
                    Random r = new Random();
                    int computerC = r.Next(3);
                    Console.WriteLine("Choose either rock, paper, or scissors");
                    string userC = Console.ReadLine();
                    if (computerC == 0)
                    {
                        Console.WriteLine("The computer chooses Rock");
                        if (userC == "rock")
                        {
                            Console.WriteLine("It's a tie.");
                        }
                        else if (userC == "paper")
                        {
                            Console.WriteLine("Congrats, you've won!!");
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                        }
                    }
                    else if (computerC == 1)
                    {
                        Console.WriteLine("The computer chooses Paper");
                        if (userC == "rock")
                        {
                            Console.WriteLine("You lost!");
                        }
                        else if (userC == "paper")
                        {
                            Console.WriteLine("It's a tie");
                        }
                        else
                        {
                            Console.WriteLine("Congrats, you've won!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The computer chooses Scissors");
                        if (userC == "rock")
                        {
                            Console.WriteLine("Congrat's, you've won!!");
                        }
                        else if (userC == "paper")
                        {
                            Console.WriteLine("You lost!");
                        }
                        else
                        {
                            Console.WriteLine("It's a tie");
                        }
                    }
                }
            }
            while (Console.ReadLine() == "y");

        }
    }
}
