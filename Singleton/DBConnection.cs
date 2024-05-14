using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    
    public class DBConnection
    {
        //ek hi object banana chaiye class ka 
        /*  private static object o = new object();
          private static DBConnection _obj;
          private DBConnection() { } //private constuctor se object nahii banenga class ka 

          public static DBConnection Instance
          {

              get
              {
                  if (_obj == null) // performance ke liye 
                  { //to support multi therds(Qunqant request)
                      lock (o) // abhi one request one time baki request waiting
                      {
                          if (_obj == null)
                          {
                              _obj = new DBConnection();
                          }
                          return _obj;
                      }
                  }
                  return _obj; // nahi nahi hai to vahi return kar
              }

          }*/


        //5 hi object banenge sirf
        private static DBConnection _obj = null;
        private static object o = new object();
        private static int _counter = 1;

        private DBConnection() { }

        public static DBConnection Instance
        {
            get
            {
                if (_counter <= 5)
                {
                    _obj = new DBConnection();
                    _counter++;
                }
                else
                {
                    Console.WriteLine("Only 5 Object are Possible");
                }
                return _obj;
            }
        }
    }
}
