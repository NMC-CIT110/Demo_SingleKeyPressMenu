using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SingleKeyPressMenu
{
    /// <summary>
    /// demonstration of using a single key stroke to make a menu choice
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool quitApplication = false;
            ConsoleKeyInfo menuChoiceKey;
            char menuChoice;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine();

                Console.WriteLine("a) Method One");
                Console.WriteLine("b) Method Two");
                Console.WriteLine("c) Method Three");
                Console.WriteLine("q) Quit");
                Console.WriteLine();

                Console.Write("Enter the letter for the menu item:");
                menuChoiceKey = Console.ReadKey();
                menuChoice = menuChoiceKey.KeyChar;

                switch (menuChoice)
                {
                    case 'a':
                        DisplayChoiceA();
                        break;

                    case 'b':
                        DisplayChoiceB();
                        break;

                    case 'c':
                        DisplayChoiceC();
                        break;

                    default:
                        quitApplication = true;
                        break;
                }

            } while (!quitApplication);
        }

        static void DisplayChoiceA()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("You chose \'a\'.");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }

        static void DisplayChoiceB()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("You chose \'b\'.");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }

        static void DisplayChoiceC()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("You chose \'c\'.");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }
    }
}
