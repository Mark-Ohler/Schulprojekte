namespace ConsoleShape.Interfaces;

// Abstrakte Klasse kann Implementierung enthalten
// aber kann nicht instanziiert werden
internal abstract class AbstractShape : IShape
{
    // gemeinsames Attribut
    public string? Bezeichnung { get; set; }
    // Konstruktor
    protected AbstractShape(string? bezeichnung)
    {
        Bezeichnung = bezeichnung;
    }
    //Methoden
    public abstract double BerechneVolumen();
    public abstract double BerechneFläche();
    // Bezeichnung ausgeben
    public virtual string GetInfos()
    {

        return $"Bezeichnung: {Bezeichnung}";
    }
}
