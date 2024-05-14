using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IProductDB
    {
        bool CreateProduct(Product product);
        // add methods to update, delete, select all, select by product id

        bool UpdateProduct(Product product);

    }
}
