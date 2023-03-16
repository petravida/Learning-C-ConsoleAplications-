using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingtheBasicsOOP
{
    public class Employee : Person
    {
        public DateTime FirstDayofWork { get; set; }    
        public int YearsofService { get; set; } 
        public Guid Company { get; set; }
    }
}
