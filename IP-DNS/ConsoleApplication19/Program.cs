using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress addr = IPAddress.Parse("69.59.196.211");
            IPHostEntry entry = Dns.GetHostEntry(addr);
            Console.WriteLine(entry.HostName);
            Console.WriteLine(entry.Aliases);
        }
    }
}
