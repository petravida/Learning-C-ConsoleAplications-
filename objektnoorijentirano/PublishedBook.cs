using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektnoorijentirano
{
    public class PublishedBook : Book
    {
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string PublishingHouse { get; set; }
        public string Shopping { get; set; }
    }
}
