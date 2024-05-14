using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                ProductId = 1,
                Name = "Shirt",
                Price = 999
            };

            ProductDB db = new ProductDB(new DatabaseLogger());
            db.Insert(product);
        }
    }
}
