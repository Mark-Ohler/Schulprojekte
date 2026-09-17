namespace CodeWars_CreatePhoneNumber;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(verarbeitung("ha3lli h2allo i7ch b6in 1ein klei5ner t4est str8ing"));
    }
    static string verarbeitung(string eingabe)
    {
        if (string.IsNullOrEmpty(eingabe))
        {
            return "";
        }
        string[]eingabeListe = eingabe.Split(' ');
        string[] ergebnis = new string[eingabeListe.Length];
        for (int i = 0; i < eingabeListe.Length; i++)
        {
            string wort = eingabeListe[i];
            foreach (char zeichen in wort)
            {
                if (char.IsDigit(zeichen))
                {
                    int position = (int)char.GetNumericValue(zeichen);
                    ergebnis[position - 1] = wort;
                }
            }
        }
        return string.Join(" ",ergebnis);


    }
}
