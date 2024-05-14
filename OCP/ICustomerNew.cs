using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public interface ICustomerNew  //Interface Segregation Principle : create new interface to fulfil requirements from new client 
    {
        void FreeFoodOrder();
    }
}
