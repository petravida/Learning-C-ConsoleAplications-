using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingtheBasicsOOP
{
    public abstract class Person : IPerson
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        private int OIB { get; set; }
        
    }
}
