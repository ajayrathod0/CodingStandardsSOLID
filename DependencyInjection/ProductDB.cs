using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ProductDB // High Level Module
    {
        private IProductBL _obj = null;

        public ProductDB()
        {
        }

        public ProductDB(IProductBL obj)  //1. way Using Contructor
        {
            _obj = obj;
        }

        /* public IProductBL Instance //Using Properties
         {
             set
             {
                _obj = value;
             }

         }*/

        /*  public void SetDependency(IProductBL obj) //Using Method
          {
              _obj = obj;
          }*/

        public void Insert()
        {//dependency injection yahi bolta hai ki high lavel module ke uper depend nahi hona chaiye low level modul

            //ProductBL bl = new ProductBL();  //or Dependency Injection bolta hai ki kisi Interface or abstract class ke
            //through depend hona chaiye or interface ka object nahi banta uske liye "Injecting dependency hai"
            // bl.Insert();

            _obj.Insert();
        }
    }
}
