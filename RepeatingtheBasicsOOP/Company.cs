using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingtheBasicsOOP
{
    public class Company
    {
        public Guid Id { get; set; }   
        public string Name { get; set; }    
        public int NumberofEmployees { get; set; }  
        public bool WeekendWork { get; set; }
        public Guid Director { get; set; }
        public Guid City { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Service> Services { get; set; }

        public void GetNumberofEmployees(string name, int number)
        {
            this.Name = name;
            this.NumberofEmployees = number;
            Console.WriteLine("Company {0} has {1} employees.", name, number);
        }
        public void GetNumberofEmployees()
        {
            Console.WriteLine(Name + " " + NumberofEmployees);
        }
        

    }

}
