namespace ConsoleShape.Interfaces;

// Interface enthält keine Implementierung
// und kann nicht instanziiert werden

public interface IShape
{
    // öffentliche Methodenköpfe - lose Kopplung
    public double BerechneVolumen();
    public double BerechneFläche();
    public string GetInfos();
}
