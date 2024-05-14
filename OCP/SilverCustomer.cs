using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class SilverCustomer : Customer, ICustomer
    {
        public void PrintTicket()
        {
            Console.WriteLine("SilverCustomer Ticket Print");
        }
    }
}
