using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningWriteLineReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*string name;
            float vrijednost1;
            int vrijednost2;
            bool vrijednost3;
            double vrijednost4;*/


            /*Console.WriteLine("Enter your Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your LastName:");
            string surname = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int yourAge = Int32.Parse(Console.ReadLine());

            if (yourAge < 30)
            {
                Console.WriteLine("You are so young!");
            }
            else
            {
                Console.WriteLine("You are old haha");
            }
            Console.ReadLine();
            Console.WriteLine("Welcome" + " " + (char.ToUpper(firstName[0]) + firstName.Substring(1)) + " " +
                char.ToUpper(surname[0]) + surname.Substring(1) + '(' + yourAge + ')' + '!');
            Console.ReadLine();
            Console.WriteLine("How tall are you?");
            float tall = float.Parse(Console.ReadLine());
            Console.WriteLine("Do you have dog?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Lucky you!");
            }
            else if (answer == "no")
            {
                Console.WriteLine("I am sorry!");
            }

            Console.ReadLine();*/


            /*int number1 = 5;
            int number2 = 9;
            decimal number3 = 66.587M;
            int number4 = 697;
            int number5 = -54;
            decimal number6 = 98.547M;
            int[] firstArray = { number1, number2, number4, number5 };

            Console.WriteLine(number1 + number2);
            Console.WriteLine(Math.Sqrt(number2));
            Console.WriteLine(Math.Round(number3));
            Console.WriteLine(Math.Round(number6));
            Console.WriteLine(Math.Abs(number5));
            firstArray.Max();
            firstArray.Min();
            firstArray.Sum();*/

            /*Console.WriteLine("Write some whole number:");
            double someNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(someNumber));
            Console.WriteLine("Write some whole negative number:");
            double someNumber1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(someNumber1));
            Console.WriteLine("Write some decimal number:");
            decimal somenumber2 = Decimal.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(somenumber2));

            Console.WriteLine("Write some whole number");
            int writtenNumber = Int32.Parse(Console.ReadLine());
            if (writtenNumber < 50)
            {
                Console.WriteLine("You wrote number less 50.");
            }
            else if (writtenNumber == 50)
            {
                Console.WriteLine("You wrote 50.");
            }
            else 
            {
                Console.WriteLine("You wrote number larger then 50.");
            }*/
            
            
            Console.WriteLine("Write some decimal number:");
            string value = Console.ReadLine();
            if (Decimal.TryParse(value, out decimal somenumber2))
            {
                Console.WriteLine("Susccess");

            }
            else { Console.WriteLine("Fail"); 
            }

            //int? broj1 = null;


            //Console.ReadLine();
        }
    }
}
