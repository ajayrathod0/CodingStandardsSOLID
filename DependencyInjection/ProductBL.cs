using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ProductBL : IProductBL //Low Level Model
    {
        public ProductBL(ProductDB productDB)
        {
            ProductDB = productDB;
        }

        public ProductDB ProductDB { get; }

        public void Insert()
        {
            Console.WriteLine("Product Inserted Successfully");
        }
    }
}
