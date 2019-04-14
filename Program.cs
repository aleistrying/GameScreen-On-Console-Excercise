using System;

namespace Excercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 − New Game");
            Console.WriteLine("2 − Load Game");
            Console.WriteLine("3 − Options");
            Console.WriteLine("4 − Quit");
            Console.WriteLine("=============");
            Console.WriteLine("");
            Console.Write("Select the option from the menu");
            Console.WriteLine();
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Loading  game . . .");
            if(input == 1)
            {
                Console.WriteLine("You selected a new game file");
            }
            else if (input == 2)
            {
                Console.WriteLine("You selected to load your previous game");
            }
            else if (input == 3)
            {
                Console.WriteLine("You selected the Options menu");
            }
            else if (input == 4)
            {
                Console.WriteLine("Quitting game . . .");
            }
            else
            {
                Console.WriteLine("You wrote an invalid value");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to quit . . .");
            Console.ReadKey();
        }
    }
}
