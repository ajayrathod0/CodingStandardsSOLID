using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ProductDB db = new ProductDB();
             db.Insert();*/


            //Using Contructor most usess
            /* ProductDB bl = new ProductDB(new ProductBL());
             bl.Insert();
 */

            //Using Properties
            /* ProductDB bl = new ProductDB();
              bl.Instance = new ProductBL();
             bl.Insert();*/


            //Using Method
            /*ProductDB db = new ProductDB();
            db.SetDependency(new ProductBL());
            db.Insert();

*/



            //new keyword nahi aana chaiye useke Liye Unity package install karenge 

            var content = new UnityContainer();
            //Regester 
            content.RegisterType<IProductBL, IProductBL>();

            //Resolve
            ProductDB bl = content.Resolve<ProductDB>();
            bl.Insert();

            Console.ReadLine();
        }
    }
}
