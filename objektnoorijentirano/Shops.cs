using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektnoorijentirano
{
    public class Shops
    {
        public string Market { get; set; }

        public string City { get; set; }

        public Shops(string a, string b)
        {
            Market = a;
            City = b;
        }
        public Shops( Shops s)
        {
            Market = s.Market;
            City = s.City;
        }
        public string getShops()
        {
            return Market + "," + City;
        }

      
    }
}
