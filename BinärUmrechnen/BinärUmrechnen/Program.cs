namespace BinärUmrechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Binärumrechner");
                int eingabe = Eingabe();
                string verarbeitung = Verarbeitung(eingabe);
                Ausgabe(verarbeitung);
                Console.WriteLine("Zum beenden q/Q drücken, für weiter bitte Enter drücken");
                string loop = Console.ReadLine().ToLower();
                if (loop == "q")
                {
                    break;
                }
            }
        }
        static int Eingabe()
        {
            Console.WriteLine("Bitte geben Sie Ihre Decimal Zahl ein ");
            int eingabe = Convert.ToInt32(Console.ReadLine());
            return eingabe;
        }

        static string Verarbeitung(int eingabe)
        {
            if (eingabe == 0)
            {
                return "0";
            }
            List<int> reste = new List<int>();
            while (eingabe > 0)
            {
                int rest = eingabe % 2;
                reste.Add(rest);
                eingabe /= 2;
            }
            reste.Reverse();
            string ausgabe = string.Join(" ", reste);
            return ausgabe;
        }
        static void Ausgabe(string ausgabe)
        {
            Console.WriteLine("Ihre Binärzahl lautet: " + ausgabe);
        }
    }
}
