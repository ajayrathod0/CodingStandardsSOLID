using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer()
        {
            Name = "Normal Customer";
        }
    }

    public class SilverCustomer : Customer
    {
        public SilverCustomer()
        {
            Name = "Silver Customer";
        }
    }

    public class GoldCustomer : Customer
    {
        public GoldCustomer()
        {
            Name = "Gold Customer";
        }
    }
    public class PlatinumCustomer : Customer
    {
        public PlatinumCustomer()
        {
            Name = "Platinum Customer";
        }
    }
}
