using System.Linq.Expressions;

namespace ConsoleRechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Optics:
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            //Programmlogik - Funktionsaufruf in Dauerschleife
            string strEnde = "";
            while (strEnde !="q")
            {
                var (operation, zahl1, zahl2) = Eingabe();
                double ergebnis = Rechnung(operation, zahl1, zahl2);
                Ausgabe(zahl1, zahl2, operation, ergebnis);


                Console.WriteLine("\n\nWollen Sie weiter rechnen oder beenden(q)?");
                strEnde= Console.ReadLine();
                Console.WriteLine();
            }
        }
        static (string, double, double) Eingabe()
        {
            Console.WriteLine("ConsoleRechner\n");

            Console.Write("Bitte geben Sie die erste Zahl ein: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte geben Sie die Rechenart ein: ");
            string operation = Console.ReadLine();
            Console.Write("Bitte geben Sie die zweite Zahl ein: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());
            return (operation, zahl1, zahl2);

        }
        static double Rechnung(string operation, double zahl1, double zahl2)
        {
            double ergebnis;
            switch (operation)
            {
                case "+":
                    ergebnis = zahl1 + zahl2;
                    return ergebnis;
                case "-":
                    ergebnis = zahl1 - zahl2;
                    return ergebnis;
                case "/":
                    ergebnis = zahl1 / zahl2;
                    return ergebnis;
                case "*":
                    ergebnis = zahl1 * zahl2;
                    return ergebnis;
                default: 
                    return 0; 
            }
            
        }
        static void Ausgabe(double zahl1, double zahl2, string operation, double ergebnis)
        {
            if (ergebnis != 0)
            {
                Console.WriteLine($"Das Ergebnis lautet: {zahl1} {operation} {zahl2} = {ergebnis}");    
            }
            else
            {
                Console.WriteLine("Ihre Eingabe war ungültig");
            }
        }
    }
}
