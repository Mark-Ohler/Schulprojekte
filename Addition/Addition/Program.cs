using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition\n");

            Console.Write("Bitte geben Sie die erste Zahl ein: ");
            string zahl1 = Console.ReadLine();
            double zahldouble = Convert.ToDouble(zahl1);

            Console.Write("Bitte geben Sie die zweite Zahl ein: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Das Ergebnis Ihrer Addition ist: ");
            Console.WriteLine(zahldouble + zahl2);
            Console.ReadLine();

        }
    }
}
