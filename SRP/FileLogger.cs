using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText(@"Data\errors.txt", message);
        }
    }
}
