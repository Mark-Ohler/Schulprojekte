namespace EAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe = Eingabe();
            bool verarbeitung = Verarbeitung(eingabe);
            Ausgabe(verarbeitung);
        }
        static string Eingabe()
        {
            Console.WriteLine("Bitte EAN Nummer eingeben");
            var eingabe = Console.ReadLine()!;
            return eingabe;

        }
        static bool Verarbeitung(string eingabe)
        {
            int summe = 0;
            int[] eListe = new int[eingabe.Length];
            for (int i = 0; i < eingabe.Length; i++) 
            {
                eListe[i]= eingabe[i] - '0';
            }
            Console.WriteLine( eListe);
            for (int i = 0; i < eListe.Length; i++)
            {
                if (i % 2 == 0)
                {
                    summe += eListe[i] * 1; 
                }
                else
                {
                    summe += eListe[i] * 3;
                }
            }

            Console.WriteLine("summe:" + summe);
            if (summe%10==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Ausgabe(bool ergebnis)
        {
            if (ergebnis) { Console.WriteLine("Die EAN ist gültig"); }
            else
            {
                Console.WriteLine("Die EAN ist ungültig");
            }
        }
    }
}
