using ConsoleShape.Interfaces;
using ConsoleShape.Körper;
using System.Transactions;

namespace ConsoleShape;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ConsoleShape");

        // Objekte anlegen
        Quader quader1 = new Quader("Quader 17", 2.1, 3, 4);

        Quader quader2 = new Quader("Quader 51", 1.1, 5, 2);

        Kugel kugel1 = new Kugel("Kugel 1", 7);

        Kugel kugel2 = new Kugel("Kugel 723", 28.3);

        Zylinder zylinder1 = new Zylinder("Zylinder 345", 17.1, 50);

        Zylinder zylinder2 = new Zylinder("Zylinder 987", 10, 30);

        Pyramide pyramide1 = new Pyramide("Pyramide 24", 5.0, 7.0, 10);

        Pyramide pyramide2 = new Pyramide("Pyramide 42", 10.0, 14.0, 25);

        Würfel würfel1 = new Würfel("Würfel 1", 10);

        Würfel würfel2 = new Würfel("Würfel 345", 25);

        // Liste mit IShape-Elementen anlegen
        List<IShape> shapes = new List<IShape>();

        // Geometrische Objekte hinzufügen
        shapes.Add(quader1);
        shapes.Add(quader2);
        shapes.Add(kugel1);
        shapes.Add(kugel2);
        shapes.Add(zylinder1);
        shapes.Add(zylinder2);
        shapes.Add(pyramide1);
        shapes.Add(pyramide2);
        shapes.Add(würfel1);
        shapes.Add(würfel2);

        // Variablen für Statistik anlegen
        double minVolumen = double.MaxValue;
        double maxVolumen = double.MinValue;
        double minFläche = double.MaxValue;
        double maxFläche = double.MinValue;
        string minVol = "";
        string maxVol = "";
        string minFl = "";
        string maxFl = "";


        foreach (IShape shape in shapes)
        {
            Console.WriteLine(shape.GetInfos());
            if (shape.BerechneVolumen() < minVolumen)
            {
                minVolumen = shape.BerechneVolumen();
                minVol = ((AbstractShape)shape).Bezeichnung;
            }
            if (shape.BerechneVolumen() > maxVolumen)
            {
                maxVolumen = shape.BerechneVolumen();
                maxVol = ((AbstractShape)shape).Bezeichnung;
            }
            if (shape.BerechneFläche() < minFläche)
            {
                minFläche = shape.BerechneFläche();
                minFl = ((AbstractShape)shape).Bezeichnung;

            }
            if (shape.BerechneFläche() > maxFläche)
            {
                maxFläche = shape.BerechneFläche();
                maxFl = ((AbstractShape)shape).Bezeichnung;

            }
        }
        Console.WriteLine($"\n\n\nMin-Volumen: {minVol}-- {minVolumen:N2} \nMax-Volumen: {maxVol}-- {maxVolumen:N2} " +
            $"\nMin-Fläche: {minFl}-- {minFläche:N2} \nMax-Fläche: {maxFl}-- {maxFläche:N2}");
    }
}
