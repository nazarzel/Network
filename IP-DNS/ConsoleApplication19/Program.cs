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
            IPAddress addr = IPAddress.Parse("87.240.188.250");
            IPHostEntry entry = Dns.GetHostEntry(addr);
            Console.WriteLine(entry.HostName);
            string howtogeek = "vk.com";
            IPAddress[] addresslist = Dns.GetHostAddresses(howtogeek);

            foreach (IPAddress theaddress in addresslist)
            {
                Console.WriteLine(theaddress.ToString());
            }
        }
    }
}
