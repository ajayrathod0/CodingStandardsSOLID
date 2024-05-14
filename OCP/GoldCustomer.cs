using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class GoldCustomer : Customer, ICustomer
    {
        public void PrintTicket()
        {
            Console.WriteLine("Gold Customer Ticket Print");
        }
    }
}
