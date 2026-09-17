using System.Windows;
using System.Windows.Controls;

namespace WpfTeilnehmerVerwaltung
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            string vorsteuerabzug = "";
            if (RadioBerechtigt.IsChecked == true)
                vorsteuerabzug = RadioBerechtigt.Content.ToString() ?? "";
            else if (RadioNichtBerechtigt.IsChecked == true)
                vorsteuerabzug = RadioNichtBerechtigt.Content.ToString() ?? "";
            else if (RadioTeilweise.IsChecked == true)
                vorsteuerabzug = RadioTeilweise.Content.ToString() ?? "";

            Teilnehmer teilnehmer = new Teilnehmer
            {
                Anrede = (ComboBoxAnrede.SelectedItem as ComboBoxItem)?.Content.ToString() ?? "",
                Vorname = TextBoxVorname.Text,
                Name = TextBoxName.Text,
                Vorsteuerabzug = vorsteuerabzug,
                Postleitzahl = TextBoxPlz.Text,
                Kurs = (ComboBoxKurs.SelectedItem as ComboBoxItem)?.Content.ToString() ?? ""
            };

            string ausgabe = $"{teilnehmer.Anrede} {teilnehmer.Vorname} {teilnehmer.Name}, " +
                              $"Vorsteuerabzug {teilnehmer.Vorsteuerabzug}, " +
                              $"{teilnehmer.Postleitzahl} - {teilnehmer.Kurs}";
            MessageBox.Show(ausgabe, "Neuer Teilnehmer");

            ComboBoxAnrede.SelectedIndex = -1;
            TextBoxName.Clear();
            TextBoxVorname.Clear();
            TextBoxPlz.Clear();
            ComboBoxKurs.SelectedIndex = -1;
            RadioBerechtigt.IsChecked = false;
            RadioNichtBerechtigt.IsChecked = false;
            RadioTeilweise.IsChecked = false;

            TextBoxName.Focus();
        }

        private void ButtonAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
    public class Teilnehmer
    {
        public string Anrede { get; set; }
        public string Vorname { get; set; }
        public string Name { get; set; }
        public string Vorsteuerabzug { get; set; }
        public string Postleitzahl { get; set; }
        public string Kurs { get; set; }
    }
}
