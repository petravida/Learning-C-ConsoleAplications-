using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsandLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool myMenu = true;
            while (myMenu)
            {
                myMenu = Menu();
            }
            Console.ReadLine();
            
        }
        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. Prizes for you");
            Console.WriteLine("2. Print numbers");
            Console.WriteLine("3. Guess the number");
            Console.WriteLine("4. Exit.");

            string result = Console.ReadLine();
            if (result == "1")
            {
                PrizesForYou();
                return true;
            }
            else if (result == "2")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "3")
            {
                GuessTheNumber();
                return true;
            }
            else if (result == "4")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private static void PrizesForYou()
        {
            Console.Clear();
            Console.WriteLine("Prizes for you!");
            Console.WriteLine("Pick one number: ");
            int prize = Int32.Parse(Console.ReadLine());
            switch (prize)
            {
                case 1:
                    Console.WriteLine("You won a mobilephone!");
                    break;

                case 2:
                    Console.WriteLine("You won a car!");
                    break;

                case 3:
                    Console.WriteLine("You won a dog");
                    break;
                
                case 4:
                    Console.WriteLine("You won a trip!");
                    break;

                default:
                    Console.WriteLine("You didn't won anything!");
                    break;


            }
            Console.ReadLine();
            
        }
        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Pick some number and I will show you even numbers:");
            int result = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < result; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
          
        }
        private static void GuessTheNumber()
        {
            Console.Clear();
            Console.WriteLine("Guess the number between 1 and 10.");

            Random myrendom = new Random();
            int randomNumber = myrendom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;
            do
            {
                   
                 string resuls = Console.ReadLine();
                  
                guesses++;
                if (resuls == randomNumber.ToString())
                    incorrect = false;
                else Console.WriteLine("Try again.");


            } while (incorrect);
            Console.WriteLine("Correct! You needed {0} guesses.", guesses);

            Console.ReadLine();
        }
    }

}
