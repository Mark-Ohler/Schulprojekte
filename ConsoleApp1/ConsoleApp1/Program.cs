using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2/3 Int");
            int zahl1 = 2;
            int zahl2 = 3;
            int ergebnis = zahl1 / zahl2;
            Console.WriteLine(ergebnis);

            Console.WriteLine("2/3,0");
            int zahl3 = 2;
            double zahl4 = 3.0;
            Console.WriteLine(zahl3 / zahl4);

            Console.WriteLine("2,0/3");
            double zahl5 = 2.0;
            int zahl6 = 3;
            Console.WriteLine(zahl5 / zahl6);
        }
    }
}
