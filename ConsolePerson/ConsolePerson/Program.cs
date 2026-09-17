namespace ConsolePerson;


internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Konsolen Programm";
        Console.WriteLine("ConsolePerson");
        // Eine neue Instanz/Objekt der Klasse Person anlegen und mittels Konstruktor Werte setzen
        Person person1 = new Person("Harald","Müller",new DateTime(1990,8,21));
        Person person2 = new Person("Heidi", "Klosterfrau", new DateTime(1762, 7, 13));
        Console.WriteLine(person1.ToString());
        Console.WriteLine(person2.ToString());
        Console.ReadLine();
    }
}
class Person
{
    // Attribute
    private string vorname;
    private string name;
    public DateTime geburtstag;

    // Konstruktor
    public Person() { }  //Standartkonstruktor
    public Person(string vorname, string name, DateTime geburtstag)
    {
        this.vorname = vorname;
        this.name = name;
        geburtstag = geburtstag;
    }
    public int Alter()
    {
        DateTime heute = DateTime.Now;
        int alter = heute.Year - geburtstag.Year;
        if ((heute.Month<geburtstag.Month) || (heute.Month == geburtstag.Month && heute.Day < geburtstag.Day))
        {
            alter -= 1;
        }

        return alter;
    }

    public override string ToString()
    {
        string str = "";
        str += "\nVorname: " +vorname;
        str += "\nNachname: " + name;
        str += "\nGeburtstag: " + geburtstag.ToShortDateString();
        str += "\nAlter: " + Alter();
        return str;
    }
}
