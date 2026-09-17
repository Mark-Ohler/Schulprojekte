using ConsoleShape.Interfaces;

namespace ConsoleShape.Körper;

internal class Kugel : AbstractShape
{
    // Attribut setzen
    double Radius { get; set; }

    // Konstruktor
    public Kugel(string bezeichnung, double radius) : base(bezeichnung)
    {
        Radius = radius;
    }

    // Methoden implementieren
    public override double BerechneVolumen()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }

    public override double BerechneFläche()
    {
        return 4 * Math.PI * Math.Pow(Radius, 2);
    }
    public override string GetInfos()
    {
        return $"\n{base.GetInfos()} \nRadius: {Radius} \nDurchmesser: {2 * Radius} " +
            $"\nVolumen: {BerechneVolumen():N2} \nOberfläche: {BerechneFläche():N2}";
    }
}
