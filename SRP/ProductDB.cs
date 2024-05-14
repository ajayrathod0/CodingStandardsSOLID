using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class ProductDB
    {
        ILogger _log; //ILogger interface type 

        public ProductDB(ILogger log)
        {
            _log = log;
        }
        public void Insert(Product product)
        {
            try
            {
                //ado.net code
            }
            catch (Exception ex)
            {
                string massage = $"Error occurred : {ex.Message} at {DateTime.Now} \n";
                // File.AppendAllText(@"Data\errors.txt", massage); //saprate class bana kar method me likhenge vaha ek bar likhnge , ese bahut sare method bhi honge to sirf ek bar hi chnages karna padenga
                /*  FileLogger log = new FileLogger(); //DIP bolta hai ki dusre class par depend nahi hona chaiye
                  log.Log(massage);*/

                _log.Log(massage);
            }

        }
    }
}
