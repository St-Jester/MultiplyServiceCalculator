using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host =
                new ServiceHost(typeof(ManyCalculators.Service1));

            host.Open();
            Console.WriteLine("Opened");

            Console.ReadLine();

            host.Close();
        }
    }
}
