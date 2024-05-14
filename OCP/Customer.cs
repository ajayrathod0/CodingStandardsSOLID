using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public abstract class Customer
    {
        public void ShowsTimings()
        {
            Console.WriteLine("*** All Today Shows ***");
        }
        // public abstract void PrintTicket(); //yah abstract method ko interface me likhenge kyu
        // ki LSP me perfect child hona chaiye jo inquiry ke liye aa raaha hai main method me error aayenga use ticket nahi de sakte inhirate
        // to yaah ticket wala method interface me likhenge oe jisko tickte chiye vah inharite karenga interface ko
    }

}
