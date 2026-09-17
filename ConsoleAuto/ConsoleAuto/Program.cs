using System.IO;
using System.Xml.Serialization;
namespace ConsoleAuto;
internal class Program
{
    static XmlSerializer xml = new XmlSerializer(typeof(List<Auto>));
    static List<Auto> autos = new List<Auto> {
        new Auto("Audi", "A6 2.0 TDI", 1968, 232, 8.4, 140.6),
        new Auto("Mercedes", "C200", 2148, 234, 8.1, 125.8),
        new Auto("BMW", "320i", 1998, 2345, 7.2, 136.16),
        };
    static void Main(string[] args)
    {
        string eingabe = "";
        while (eingabe != "6")
        {
            eingabe = Eingabe();
            Verarbeitung(eingabe);
        }
    }
    static string Eingabe() 
    {
        Console.WriteLine("------------CHOOOOOSE------------");
        Console.WriteLine("Treffen Sie eine Auswahl");
        Console.WriteLine("1: Autos anzeigen \n2: Autos hinzufügen \n3: Autos entfernen \n4: Liste Speichern \n5: gespeicherte Liste Laden \n6: beenden");
        Console.Write("Ihre Auswahl?: ");
        string eingabe= Console.ReadLine()!;
        return eingabe;
    }
    static void ListeAnzeigen()
    {
        for (int i = 0; i < autos.Count; i++) 
        {
            Console.WriteLine($"\n[{i + 1}]");
            Console.WriteLine(autos[i].ToString());
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
    static void Verarbeitung(string eingabe) 
    {

        switch (eingabe)
        {
            case "1":
                ListeAnzeigen();
                break;
            case "2":
                Console.Write("\nBitte Geben Sie die Fahrzeugmarke ein: ");
                string Fahrzeugmarke = Console.ReadLine()!;
                Console.Write("\nBitte Geben Sie den Fahrzeugtyp ein: ");
                string Fahrzeugtyp = Console.ReadLine()!;
                Console.Write("Bitte Geben Sie den Hubraum ein: ");
                int Hubraum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bitte Geben Sie die Höchstgeschwindigkeit ein: ");
                int Hoechstgeschwindigkeit = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bitte Geben Sie die Beschleunigung ein: ");
                double Beschleunigung = Convert.ToDouble(Console.ReadLine());
                Console.Write("Bitte Geben Sie die KiloWatt(Kw) an: "); 
                double KiloWatt = Convert.ToDouble(Console.ReadLine());
                autos.Add(new Auto(Fahrzeugmarke, Fahrzeugtyp, Hubraum,Hoechstgeschwindigkeit, Beschleunigung, KiloWatt));
                break;

            case "3":
                ListeAnzeigen();
                Console.Write("Welche wollen sie löschen?: ");
                int auswahl = Convert.ToInt32(Console.ReadLine());
                if (auswahl >= 1 && auswahl <= autos.Count)
                {
                    autos.RemoveAt(auswahl - 1);
                    Console.WriteLine("Auto wurde entfernt");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe");

                }
                break;

            case "4":
                AutoSpeichern();
                Console.Write("Ihre Liste wird gespeichert unter Auto.xml für spätere Ansicht.");
                Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                break;
            case "5":
                AutoEinlesen();
                Console.WriteLine("Ihr vorher gespeicherte Liste wurde geladen");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Ungültige Eingabe");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                break;

        }
    }
    static void AutoSpeichern()
    {
        StreamWriter streamW = new StreamWriter("Auto.xml");
        xml.Serialize(streamW, autos);
        streamW.Close();
        Console.WriteLine("Anzahl Autos gespeichert: " + autos.Count);
    }
    static void AutoEinlesen()
    {
        StreamReader streamR = new StreamReader("Auto.xml");
        autos = (List<Auto>)xml.Deserialize(streamR)!;
        streamR.Close();
        Console.WriteLine("Anzahl Auto eingelesen: " + autos.Count);
    }
}
[Serializable]
public class Auto
{
    public int hubraum;
    public string hersteller;
    public string bezeichnung;
    public int hoechstgeschwindigkeit;
    public double beschleunigung;
    public double kw;

    // Methoden
    public double KwUmrechnen()
    {
        double ps = kw * 1.36;
        return ps;
    }
    public override string ToString()
    {
        double ps = KwUmrechnen();
        string str = "";
        str += "\nMarke: ".PadRight(40) +  hersteller;
        str += "\nBezeichnung: ".PadRight(40) + bezeichnung;
        str += "\nHubraum: ".PadRight(40) + hubraum;
        str += "\nPS: ".PadRight(40) + ps.ToString("F1");
        str += "\nHöchstgeschwindigkeit: ".PadRight(40) + hoechstgeschwindigkeit;
        str += "\nBeschleunigung: ".PadRight(40) + beschleunigung;
        str += "\nKiloWatt: ".PadRight(40) + kw;

        return str;
    }

    // Konstruktor
    public Auto() { } // Standartkonstruktor
    public Auto(string hersteller, string bezeichnung, int hubraum, int hoechstgeschwindigkeit, double beschleunigung,  double kw)
    {
        this.beschleunigung = beschleunigung;
        this.bezeichnung = bezeichnung;
        this.hersteller = hersteller;
        this.hoechstgeschwindigkeit = hoechstgeschwindigkeit;
        this.kw = kw;
        this.hubraum = hubraum;
    }
}
