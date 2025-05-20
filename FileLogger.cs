using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class FileLogger : ILogger
    {
        public void creatLog(string x, string y)
        {
            Console.WriteLine("file sends");
        }
    }
}
