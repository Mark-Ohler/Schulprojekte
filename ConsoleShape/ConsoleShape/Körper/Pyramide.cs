using ConsoleShape.Interfaces;

namespace ConsoleShape.Körper;

internal class Pyramide : AbstractShape
{
    double Länge { get; set; }
    double Breite { get; set; }
    double Höhe { get; set; }

    public Pyramide(string bezeichnung, double länge, double breite, double höhe) : base(bezeichnung)
    {
        Länge = länge;
        Breite = breite;
        Höhe = höhe;
    }

    // Methoden
    public override double BerechneVolumen()
    {
        return ((1.0 / 3.0) * (Länge * Breite) * Höhe);
    }
    public override double BerechneFläche()
    {
        double hsa = Math.Sqrt(Math.Pow(Höhe, 2) + Math.Pow(Breite / 2.0, 2));
        double hsb = Math.Sqrt(Math.Pow(Höhe, 2) + Math.Pow(Länge / 2.0, 2));

        double grundfläche = Länge * Breite;
        double mantelfläche = Länge * hsa + Breite * hsb;

        return grundfläche + mantelfläche;
    }
    public override string GetInfos()
    {
        return $"\n{base.GetInfos()} \nLänge: {Länge} \nBreite: {Breite} \nHöhe: {Höhe}" +
            $"\nVolumen: {BerechneVolumen():N2} \nOberfläche: {BerechneFläche():N2}";
    }


}
