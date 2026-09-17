using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAufgabeCallis
{
    internal class Teilnehmer
    {
        internal string Anrede { get; set; }
        string Vorname { get; set; }
        string Name { get; set; }
        string Vorsteuerabzug { get; set; }
        string Postleitzahl { get; set; }
        string Kurs { get; set; }

        internal Teilnehmer(string anrede, string vorname, string name, string vorsteuerabzug, string postleitzahl, string kurs)
        {
            Anrede = anrede;
            Vorname = vorname;
            Name = name;
            Vorsteuerabzug = vorsteuerabzug;
            Postleitzahl = postleitzahl;
            Kurs = kurs;

            object o = new object();
            o.ToString();
        }
        public override string ToString()
        {
            return $"{Anrede} {Vorname} {Name}, Vorsteuerabzug: {Vorsteuerabzug}, {Postleitzahl} - {Kurs}";
        }

    }
}

