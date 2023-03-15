using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektnoorijentirano
{
    public interface IAuthor
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime Birthday { get; set; }
    }
}
