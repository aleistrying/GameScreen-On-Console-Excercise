using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5C2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool on = true;
            while (on == true)
            {
                Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗");
                Console.WriteLine("Menu:");
                Console.WriteLine("1−NewGame");
                Console.WriteLine("2−LoadGame");
                Console.WriteLine("3−Options");
                Console.WriteLine("4−Quit");
                Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗");
                Console.WriteLine("");
                Console.WriteLine("Choose a number from the menu");
                int value = int.Parse(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.WriteLine("You chose a NewGame");
                        Console.WriteLine("Loading . . .");
                        break;
                    case 2:
                        Console.WriteLine("You chose to LoadGame");
                        Console.WriteLine("Loading . . .");
                        break;
                    case 3:
                        Console.WriteLine("You chose Options");
                        Console.WriteLine("Loading . . .");
                        break;
                    case 4:
                        on = false;
                        Console.WriteLine("App Closing . . .");
                        break;
                    default:
                        Console.WriteLine("You Chose a value that's  not in the list");
                        Console.WriteLine("Please choose a number from the menu");
                        value = int.Parse(Console.ReadLine());
                        break;
                }

            }

        }
    }
}
