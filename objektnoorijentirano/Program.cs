using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektnoorijentirano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author firstAuthor = new Author();
            firstAuthor.FirstName = "Liane";
            firstAuthor.LastName = "Moriarty";
            firstAuthor.WrittenBooks = 5;
            Console.WriteLine(firstAuthor.FirstName + " " + firstAuthor.LastName);

            PublishedBook firstBook = new PublishedBook();
            firstBook.Title = "Apples never fall";
            firstBook.Price = 13.50M;
            firstBook.PublishingHouse = "Mozaik knjiga";
            Console.WriteLine("Title: " + firstBook.Title);
            Console.WriteLine("Publishing House: " + firstBook.PublishingHouse);
            Console.WriteLine("Price: " + firstBook.Price);

            PublishedBook secondBook = new PublishedBook();
            secondBook.Title = "What Alice Forgot";
            secondBook.NumberofPages = 452;
            secondBook.Genre = "Drama";
            secondBook.PublishingHouse = "Znanje";

            PublishedBook thirdBook = new PublishedBook();
            thirdBook.Title = "Little Lies";
            thirdBook.Price = 12;
            thirdBook.PublishingHouse = "Mozaik knjiga";


            Shops shop1 = new Shops("Svijet knjige", "Osijek");
            Shops shop2 = new Shops(shop1);
            Console.WriteLine(shop2.getShops());
            thirdBook.Shopping = shop2.getShops();
            Console.WriteLine(thirdBook.Title + " " + thirdBook.Shopping);


            Author secondAuthor = new Author();
            secondAuthor.FirstName = "Dorothy";
            secondAuthor.LastName = "Koomson";

            List<Prize> listofprizes = new List<Prize>();
            secondAuthor.Prizes = listofprizes;
            string exit = "e";
            do
            {
                Prize award = new Prize();
                Console.WriteLine("Enter the Prize: ");
                award.PrizesName = Console.ReadLine();
                listofprizes.Add(award);
                Console.WriteLine("To finish press e or press any other key to continue.");
                exit = (Console.ReadLine());
            }
            while (exit != "e");

            Console.WriteLine(secondAuthor.FirstName);
            Console.WriteLine(secondAuthor.LastName);
            foreach (Prize award in secondAuthor.Prizes)
            {
                Console.WriteLine(award.PrizesName);

            }


            Console.ReadLine();
        }
        


    }
}
