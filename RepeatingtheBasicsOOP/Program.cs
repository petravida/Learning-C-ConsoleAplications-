using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingtheBasicsOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company companyOne = new Company();
            Guid g = Guid.NewGuid();
            companyOne.Id = g;
            companyOne.Name = "Sjaj";
            companyOne.NumberofEmployees = 52;
            companyOne.WeekendWork = true;
            Console.WriteLine(companyOne.Id);
            Console.WriteLine(companyOne.Name);
            Console.WriteLine(companyOne.NumberofEmployees);
            Company companyTwo = new Company();
            companyTwo.NumberofEmployees = 87;
            Company companyThree = new Company();
            companyThree.Name = "Dijamant";
            companyThree.NumberofEmployees = 105;
          
            companyOne.GetNumberofEmployees();
            companyTwo.GetNumberofEmployees();
            companyThree.GetNumberofEmployees();

            Company companyFour = new Company();
            companyFour.GetNumberofEmployees("Najsjajniji dom", 97);

            City city1 = new City("Osijek", 31000);
            City city2 = new City();
            City city3 = new City("Zagreb", 10000);


            Service service1 = new Service();
            List<Object> listaObjekata = new List<Object>();
            service1.Objects = listaObjekata;
            string exit = "x";
            do
            {   
                Object objekt = new Object();
                Console.WriteLine("Enter the object: ");
                objekt.Name = Console.ReadLine();
                listaObjekata.Add(objekt);
                Console.WriteLine("For exit press x");
                exit = Console.ReadLine();

            }
            while (exit != "x");

            List<Company> ListofCompanies = new List<Company>();
            string leave = "0";
            do
            {
                Company Com = new Company();
                Console.WriteLine("Enter new company: ");
                Com.Name = Console.ReadLine();
                ListofCompanies.Add(Com);
                Console.WriteLine("Press any key to continue. Press 0 if you want to leave.");
                leave = Console.ReadLine();
            }
            while (leave != "0");
            Console.WriteLine("You finished your list.");

            service1.Companies = ListofCompanies;
            Console.WriteLine("There is a list of service1: ");
            foreach (Company Com in service1.Companies)
            {
                Console.WriteLine(Com.Name);
            }


            Console.ReadLine();
        }
    }
}
