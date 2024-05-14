using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBConnection con1 = DBConnection.Instance;
            DBConnection con2 = DBConnection.Instance;
            DBConnection con3 = DBConnection.Instance; 
            //Eqaul aayenga kyu ki ek hi objecy ban raha hai or Equals() reference quality chack karta hai
            //agar ek se jyada object bante to else condition ka result aata kyu ki Equals() refence chack karta na ki value equality
            if (con1.Equals(con2) && con2.Equals(con3))
            {
                Console.WriteLine("Con1, Con2 and Con3 are Equals");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            DBConnection con4 = DBConnection.Instance;
            DBConnection con5 = DBConnection.Instance;
            DBConnection con6 = DBConnection.Instance; // not possible only 5 object

            Console.ReadLine();
        }
    }
}
