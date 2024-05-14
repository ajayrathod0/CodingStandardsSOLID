using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Factory
    {
        public static Customer GetCustomer(string choice)
        {
            switch (choice)
            {
                case "SILVER":
                    return new SilverCustomer();
                case "GOLD":
                    return new GoldCustomer();
                case "PLATINUM":
                    return new PlatinumCustomer();
                default:
                    return new Customer();

            }

        }
    }
}
