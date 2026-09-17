namespace ConsoleFußball;

internal class Program
{
    static List<Spieler> spielerListe = new List<Spieler>();

    static void Main(string[] args)
    {
        spielerListe.Add(new Spieler("Joshua", "Kimmich", new DateTime(1995, 02, 08), "FCB", 6));
        spielerListe.Add(new Spieler("Mats", "Hummels", new DateTime(1988, 12, 16), "BVB", 15));
        spielerListe.Add(new Spieler("Natnael", "Abraha", new DateTime(2008, 03, 14), "1899 Hoffenheim", 18));
        SpielerAnzeigen();
    }
    static void SpielerAnzeigen()
    {
        for (int i = 0; i < spielerListe.Count; i++)
        {
            Console.WriteLine(spielerListe[i].ToString());
        }
    }
    static void Auswertung()
    {
        // Durchschnittsalter berechnen
        int summeAlter = 0;
        for (int i = 0; i < spielerListe.Count; i++)
        {
            summeAlter += spielerListe[i].AlterBerechnen();
        }

        double durchschnittsalter = (double)summeAlter/ spielerListe.Count;

        // Min/Max alter bestimmen
        int maxAlter = spielerListe[0].AlterBerechnen();
        int minAlter = spielerListe[0].AlterBerechnen();
        for (int i = 0;i < spielerListe.Count;i++)
        {
            int aktuellesAlter = spielerListe[i].AlterBerechnen();
            if ( aktuellesAlter < minAlter)
            {
                minAlter = aktuellesAlter;
            }
            if (aktuellesAlter > maxAlter)
            {
                maxAlter = aktuellesAlter;
            }
        }
        // Anzahl Spieler bestimmen
        int anzahlSpieler = spielerListe.Count;

    }
}
public class Spieler
{
    // Attribute
    private string vorname;
    private string name;
    private DateTime geburtstag;
    private string verein;
    private int rueckennummer;

    // Konstruktor
    public Spieler(string vorname, string nachname, DateTime geburtstag, string verein, int rueckennummer)
    {
        this.vorname = vorname;
        this.name = nachname;
        this.geburtstag = geburtstag;
        this.verein = verein;
        this.rueckennummer = rueckennummer;
    }
    // Getter und Setter Methoden
    public void setVerein(string verein)
    {
        this.verein = verein;
    }
    public string getVerein()
    {
        return this.verein;
    }
    public void setRueckennummer(int rueckennummer)
    {
        this.rueckennummer=rueckennummer;
    }
    public int getRueckennummer()
    {
        return this.rueckennummer;
    }
    // Methoden
    public override string ToString()
    {
        int alter = AlterBerechnen();
        string str = "";
        str += "\nVorname: " + this.vorname;
        str += "\nNachname: " + this.name;
        str += "\nGeburtstag: " + geburtstag.ToShortDateString();
        str += "\nVerein: " + verein;
        str += "\nRückennummer: " + Convert.ToString(rueckennummer);
        str += "\nAlter: " + Convert.ToString(alter);
        return str;
    }
    public int AlterBerechnen()
    {
        DateTime aktuell = DateTime.Now;
        int alter = aktuell.Year - geburtstag.Year;
        if ((geburtstag.Month > aktuell.Month) || (aktuell.Month == geburtstag.Month && aktuell.Day < geburtstag.Day))
        {
           alter--;
        }
        return alter;
    }

}
