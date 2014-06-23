using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOST
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server();
            Console.WriteLine("Server Started");
            server.StartService();
            Console.WriteLine("Press a key to stop the Service");
            Console.ReadLine();
            server.StopService();
            Console.WriteLine("Server Stopped");
        }
    }
}
