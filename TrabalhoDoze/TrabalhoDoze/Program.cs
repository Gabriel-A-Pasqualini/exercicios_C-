using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace TrabalhoDoze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController service in services)
            {
                Console.WriteLine("Service: "+service.DisplayName);
            }
            Console.WriteLine();
            Console.WriteLine("Total: "+services.Count());    
        }
    }
}
