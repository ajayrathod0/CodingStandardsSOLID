using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Ticket Choice");
            string choice = Console.ReadLine().ToUpper();

            Customer c = Factory.GetCustomer(choice);
            Console.WriteLine(c.Name);

            Console.ReadLine();
        }
    }
}
