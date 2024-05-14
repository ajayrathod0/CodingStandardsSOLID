using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class PlatinumCustomer : Customer, ICustomer
    {
        public  void PrintTicket()
        {
            Console.WriteLine("PlatinumCustomer Ticket Print");
        }
    }
}
