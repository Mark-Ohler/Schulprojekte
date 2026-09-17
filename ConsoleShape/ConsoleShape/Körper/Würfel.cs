using ConsoleShape.Interfaces;

namespace ConsoleShape.Körper;

internal class Würfel : AbstractShape
{
    double Kante { get; set; }
    public Würfel(string bezeichnung, double kante) : base(bezeichnung)
    {
        Kante = kante;
    }
    public override double BerechneVolumen()
    {
        return Math.Pow(Kante, 3);
    }
    public override double BerechneFläche()
    {
        return (6 * Math.Pow(Kante, 2));
    }
    public override string GetInfos()
    {
        return $"\n{base.GetInfos()} \nKantenlänge: {Kante}" +
            $"\nVolumen: {BerechneVolumen():N2} \nOberfläche: {BerechneFläche():N2}";
    }
}
