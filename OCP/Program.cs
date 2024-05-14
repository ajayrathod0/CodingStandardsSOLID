using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Open Close Principle
            /*SilverCustomer sc = new SilverCustomer();
            sc.ShowsTimings(); //base class method call in child class

            GoldCustomer gc = new GoldCustomer();
            gc.ShowsTimings();

            PlatinumCustomer pc = new PlatinumCustomer();
            pc.ShowsTimings();*/


            //Liskov Substitution Principle
            List<ICustomer> customers = new List<ICustomer>();
            customers.Add(new SilverCustomer());
            customers.Add(new GoldCustomer());
            customers.Add(new PlatinumCustomer());
            // customers.Add(new Enquiry()); error aayenga kyu ki parfect child honga chaiye

            foreach (var item in customers)
            {
                item.PrintTicket();
            }

            Console.ReadLine();
        }
    }
}
