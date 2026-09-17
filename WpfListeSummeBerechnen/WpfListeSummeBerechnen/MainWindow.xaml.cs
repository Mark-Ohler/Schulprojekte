using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfListeSummeBerechnen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnVerlaufLöschen_Click(object sender, RoutedEventArgs e)
        {
            lbxVerlauf.Items.Clear();
        }

        private void btnBeenden_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        int[] zahlenArray = Array.Empty<int>();
        private void btnArrayFüllen_Click(object sender, RoutedEventArgs e)
        {
            // Kontrollieren das richtige Werte eingegeben werden
            if (!int.TryParse(txtArrayLength.Text, out int arrayLength))
            {
                MessageBox.Show("Bitte ganze Zahl für die Länge eingeben");
                return;
            }

            // Zufällige Zahlen generieren und zum Array hinzufügen
            Random random = new Random();
            zahlenArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                zahlenArray[i] = random.Next(0, 21);
            }
            // Array zu einem string zusammenfügen
            string strListe = string.Join(" ", zahlenArray);

            // Array zur Listbox hinzufügen
            lbxVerlauf.Items.Add($"ArrayFüllen: {strListe}");
        }

        private void btnSummeBerechnen_Click(object sender, RoutedEventArgs e)
        {
            // Wenn das Array leer ist wird die Methode abgebrochen
            if (ArrayIstLeer()) return;
                
            int summe = 0;
            foreach (var item in zahlenArray)
            {
                summe+= item;
            }
            lbxVerlauf.Items.Add($"Summe: {summe}");
        }

        private void btnMinBestimmen_Click(object sender, RoutedEventArgs e)
        {
            if (ArrayIstLeer()) return;
            int minimum = int.MaxValue;
            foreach (var item in zahlenArray)
            {
                if (item<minimum)
                {
                    minimum = item;
                }
            }
            lbxVerlauf.Items.Add($"Minimum: {minimum}");
        }
        private void btnMaxBestimmen_Click(object sender, RoutedEventArgs e)
        {
            if (ArrayIstLeer()) return;
            int maximum = int.MinValue;
            foreach (var item in zahlenArray)
            {
                if (item>maximum)
                {
                    maximum = item;
                }
            }
            lbxVerlauf.Items.Add($"Maximum: {maximum}");
        }

        private void btnAnzahlÜberLimit_Click(object sender, RoutedEventArgs e)
        {
            if (ArrayIstLeer()) return;
            // Kontrolle das ein int fürs Limit angegeben wurde
            if (!int.TryParse(txtLimit.Text, out int limit))
            {
                MessageBox.Show("Bitte geben Sie ein ganzzahliges Limit ein");
                return;
            }

            int counterLimit = 0;
            foreach (var item in zahlenArray)
            {
                if (item > limit) { counterLimit++; }
            }
            lbxVerlauf.Items.Add($"Anzahl über Limit({limit}): {counterLimit}");
        }

        // Kontrolle ob das Array befüllt wurde oder ob es leer ist.
        private bool ArrayIstLeer()
        {
            if (zahlenArray.Length == 0)
            {
                MessageBox.Show("Bitte zuerst das Array füllen");
                return true;
            }
            return false;
        }

        private void txtBoxGotFocus(object sender, RoutedEventArgs e)
        {
            TextBox? text = sender as TextBox;
            if(text.Text=="0") text.Text = "";
        }


        private void txtBoxLostFocus(object sender, RoutedEventArgs e)
        {
            TextBox? text = sender as TextBox;
            if (text.Text == "") text.Text = "0";
        }
    }
}
