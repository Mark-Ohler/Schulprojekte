namespace WinFormsAufgabeCallis
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void buttonHinzufügen_Click(object sender, EventArgs e)
        {
            // RadioButtons auswerten
            string vorsteuerabzug = "";

            if (radioButtonBerechtigt.Checked == true)
            {
                vorsteuerabzug = "berechtigt";
            }
            else if (radioButtonNichtBerechtigt.Checked == true)
            {
                vorsteuerabzug = "nicht berechtigt";
            }
            else if (radioButtonTeilweise.Checked == true)
            {
                vorsteuerabzug = "teilweise";
            }
            else
            {
                vorsteuerabzug = "nicht ausgewählt";
            }

            // Teilnehmerdaten zusammenbauen
            string teilnehmerDaten =
                $"{comboBoxAnrede.Text} {textBoxVorname.Text} {textBoxName.Text}, Vorsteuerabzug {vorsteuerabzug}, {textBoxPostleitzahl.Text} - {comboBoxKurs.Text}";

            // Teilnehmer in die ListBox einfügen
            listBoxTeilnehmer.Items.Add(teilnehmerDaten);

            // Anzahl der Teilnehmer aktualisieren
            labelAnzahlTeilnehmer.Text = "Anzahl Teilnehmer: " + listBoxTeilnehmer.Items.Count;

            // Felder leeren
            textBoxName.Text = string.Empty;
            textBoxVorname.Text = string.Empty;
            textBoxPostleitzahl.Text = string.Empty;
            comboBoxAnrede.SelectedIndex = 0;
            comboBoxKurs.SelectedIndex = 0;
            radioButtonBerechtigt.Checked = false;
            radioButtonNichtBerechtigt.Checked = false;
            radioButtonTeilweise.Checked = false;
            comboBoxAnrede.Focus();

        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Die Kombo Boxxen mit werten Befüllen
            // KomboBox Anrede befüllen
            textBoxName.Focus();
            comboBoxAnrede.Text = "Bitte Auswählen...";
            comboBoxAnrede.Items.Add("Herr");
            comboBoxAnrede.Items.Add("Frau");
            comboBoxAnrede.SelectedIndex = 0;


            // KomboBox Kurse befüllen
            comboBoxKurs.Text = "Bitte Auswählen...";
            comboBoxKurs.Items.Add("C#");
            comboBoxKurs.Items.Add("Java");
            comboBoxKurs.Items.Add("Python");
            comboBoxKurs.Items.Add("Webentwicklung");
            comboBoxKurs.SelectedIndex = 0;

            labelAnzahlTeilnehmer.Text = "Anzahl Teilnehmer: " + listBoxTeilnehmer.Items.Count;
        }
    }
}