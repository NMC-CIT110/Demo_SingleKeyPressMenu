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
            bool invalidResponse = false;
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

                Console.Write("Menu Choice:");

                //
                // feedback message for invalid response
                //
                if (invalidResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("********************************************************");
                    Console.WriteLine("*                                                      *");
                    Console.WriteLine("*    Please type the letter of the menu choice.        *");
                    Console.WriteLine("*                                                      *");
                    Console.WriteLine("********************************************************");
                }
                Console.CursorVisible = false;
                menuChoiceKey = Console.ReadKey();
                menuChoice = menuChoiceKey.KeyChar;

                switch (menuChoice)
                {
                    case 'a':
                        DisplayChoiceA();
                        invalidResponse = false;
                        break;

                    case 'b':
                        DisplayChoiceB();
                        invalidResponse = false;
                        break;

                    case 'c':
                        DisplayChoiceC();
                        invalidResponse = false;
                        break;

                    case 'q':
                        quitApplication = true;
                        break;

                    default:
                        invalidResponse = true;
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
