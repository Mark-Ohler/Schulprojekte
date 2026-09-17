namespace ZufallszahlenArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();


            Console.Title = "Zufallszahlen 2 DimensionalesArray";
            Console.WriteLine("Bitte Größe des Arrays eingeben:");
            Console.WriteLine("Wie viele Zeilen?");
            int zeilen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie viele Spalten?");
            int spalten = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie Ihren Schwellwert ein: ");
            int schwellwert = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[zeilen, spalten];
            Random zufall = new Random();
            for (int zeile = 0; zeile < zeilen; zeile++)
            {
                for (int spalte = 0; spalte < spalten; spalte++)
                {
                    int zahl = zufall.Next(0, 100);
                    matrix[zeile, spalte] = zahl;
                }
            }

            for (int i = 0; i < zeilen; i++)
            {
                for (int j = 0; j < spalten; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            int max = 0;
            int min = int.MaxValue;
            int sum = 0;
            double mittelwert = 0;
            int counter = 0;
            foreach (var item in matrix)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
                if (item < schwellwert)
                {
                    counter++;
                }
                sum += item;
            }
            double anteil = ((double)counter/(zeilen*spalten))*100;
            mittelwert = (double)sum / (zeilen * spalten);
            Console.WriteLine($"Die größte Zahl ist {max} ");
            Console.WriteLine($"Die kleinste Zahl ist {min} ");
            Console.WriteLine($"Die summe aller Zahlen ist {sum} ");
            Console.WriteLine($"Der Mittelwert aller Zahlen ist {mittelwert}");
            Console.WriteLine($"{counter} Zahlen sind unter dem Schwellwert von: {schwellwert}");
            Console.WriteLine($"Der Anteil von Zahlen unterm Schwellwert liegt bei: {anteil}%\n\n\n");


        
        
        }
    }
}
