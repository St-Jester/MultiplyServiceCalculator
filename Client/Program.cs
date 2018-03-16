using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Client.Calcs;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcs.CalculatorClient proxy = new Calcs.CalculatorClient();
            Calcs.TimeCalcClient client = new Calcs.TimeCalcClient();

            Console.WriteLine("Advanced calculator\nAllows you to know what time will the class end!");
            Console.WriteLine("For this feature enter 1\nFor default feature enter 2");
            string choice = Console.ReadLine();
            string exit = "y";
            do
            {
                switch (choice)
                {
                    case "1":
                        double mins;
                        Console.WriteLine("enter number of minutes");

                        Double.TryParse(Console.ReadLine(), out mins);
                        Console.WriteLine(client.AddMinutesToNow(mins));
                        
                        break;
                    default:

                        Console.WriteLine("First number");
                        double a;
                        Double.TryParse(Console.ReadLine(), out a);

                        Console.WriteLine("Second number");
                        double b;
                        Double.TryParse(Console.ReadLine(), out b);

                        Console.WriteLine(proxy.Sum(a, b));
                        Console.WriteLine(proxy.Sub(a, b));
                        Console.WriteLine(proxy.Mult(a, b));
                        Console.WriteLine(proxy.Divide(a, b));
                        
                        break;
                }
                Console.WriteLine("continue?");
                exit = Console.ReadLine();
                if (exit != "y")
                    break;
                Console.WriteLine("select next");
                choice = Console.ReadLine();

            } while (exit == "y");

        }
    }
}
