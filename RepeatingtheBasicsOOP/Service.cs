using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingtheBasicsOOP
{
    public class Service
    {
        public Guid Id { get; set; }    
        public decimal Price { get; set; }
        public int HoursofWork { get; set; }
        public List<Object> Objects { get; set; }   
        public List<Company> Companies { get; set; }  

    }
}
