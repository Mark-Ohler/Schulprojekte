using ConsoleShape.Interfaces;

namespace ConsoleShape.Körper;

internal class Quader : AbstractShape
{
    double Länge { get; set; }
    double Breite { get; set; }
    double Höhe { get; set; }

    // Konstruktor
    public Quader(string bezeichnung, double länge, double breite, double höhe) : base(bezeichnung)
    {
        Länge = länge;
        Breite = breite;
        Höhe = höhe;
    }
    // Methoden
    public override double BerechneVolumen()
    {
        return Länge * Breite * Höhe;
    }
    public override double BerechneFläche()
    {
        return 2 * Länge * Breite + 2 * Länge * Höhe + 2 * Höhe * Breite;
    }
    // wichtige Infos der Instanz in string schreiben
    public override string GetInfos()
    {
        return $"\n{base.GetInfos()} \nLänge: {Länge} \nBreite: {Breite} \nHöhe: {Höhe} " +
            $"\nVolumen: {BerechneVolumen():N2} \nFläche: {BerechneFläche():N2}";
    }

}
