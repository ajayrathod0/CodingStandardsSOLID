using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class VIPCustomer : Customer, ICustomerNew, ICustomer
    {
        public void FreeFoodOrder()
        {
            Console.WriteLine("VIP Customer Free Food Order");
        }

        public void PrintTicket()
        {
            Console.WriteLine("VIP Customer Ticket Print");
        }
    }
}
