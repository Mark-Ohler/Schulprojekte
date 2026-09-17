using ConsoleShape.Interfaces;

namespace ConsoleShape.Körper;

internal class Zylinder : AbstractShape
{
    double Radius { get; set; }
    double Höhe { get; set; }

    public Zylinder(string bezeichnung, double radius, double h) : base(bezeichnung)
    {
        Radius = radius;
        Höhe = h;
    }
    public override double BerechneVolumen()
    {
        return (Math.PI * Math.Pow(Radius, 2) * Höhe);
    }
    public override double BerechneFläche()
    {
        return (2 * Math.PI * Radius * (Radius + Höhe));
    }
    public override string GetInfos()
    {
        return $"\n{base.GetInfos()} \nRadius: {Radius} \nDurchmesser: {2 * Radius} \nHöhe: {Höhe}" +
            $"\nVolumen: {BerechneVolumen():N2} \nOberfläche: {BerechneFläche():N2}";
    }
}
