using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingtheBasicsOOP
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public int ZipCode { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Company> Companies { get; set; }    

        public City(string name, int zip)
        { 
            this.Name = name;
            this.ZipCode = zip;
            Console.WriteLine("The Zip Code of {0} is: {1}.", name, zip);
        }
        public City()
        {

        }
    }
    
    
}
