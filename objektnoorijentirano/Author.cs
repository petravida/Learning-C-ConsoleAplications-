using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektnoorijentirano
{
    public class Author : IAuthor 
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }
        private int OIB { get; set; }

        public int WrittenBooks { get; set; }
        public List<Prize> Prizes { get; set; }


       

        

    }
   
}
 