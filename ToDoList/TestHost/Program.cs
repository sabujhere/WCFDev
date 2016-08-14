using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ToDoList.ToDolistService)))
            {
                host.Open();
                Console.WriteLine("service host is running for todolistservice");
                Console.ReadLine();
            }
        }
    }
}
