using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiEstimation
{
    class Program
    {
        static void Main(string[] args)
        {
            var piEst = new PiTest();

            bool test = true;
            while (test)
            {
                try
                {
                    Console.Write("Please enter a positive value: ");
                    var repeatAmount = Console.ReadLine();
                    if (repeatAmount == "quit")
                    {
                        test = false;
                    }

                    int x = Convert.ToInt32(repeatAmount);

                    Console.WriteLine($"\nEstimated value:\t{piEst.CalcPi(x)}");
                    Console.WriteLine($"Actual value:\t\t{Math.PI}");
                    Console.WriteLine($"Difference:\t\t{Math.PI - piEst.CalcPi(x)}");
                    Console.WriteLine();
                }
                catch (Exception)
                {

                }

            }
        }
    }
}
