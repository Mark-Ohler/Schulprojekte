using System;
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

namespace RechnerWpf
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

        private void btnBerechnen_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtZahl1.Text, out double zahl1) || !double.TryParse(txtZahl2.Text, out double zahl2))
            {
                MessageBox.Show("Bitte gültige Zahl eingeben");
                return;
            }

            string zeichen = cboRechenArt.Text;
            double ergebnis = 0;

            switch (zeichen)
            {
                case "+":
                    ergebnis = zahl1 + zahl2;
                    break;
                case "-":
                    ergebnis = zahl1 - zahl2;
                    break;
                case "*":
                    ergebnis = zahl1 * zahl2;
                    break;
                case "/":
                    ergebnis = zahl1 / zahl2;
                    break;
                case "%":
                    ergebnis = zahl1 % zahl2;
                    break;
                default:
                    MessageBox.Show("Bitte eine Rechenart auswählen");
                    return;
            }
            txtErgebnis.Text = ergebnis.ToString();
            lbxVerlauf.Items.Add($"[{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}]: {zahl1} {zeichen} {zahl2} = {ergebnis}");
            txtZahl1.Text="0"; txtZahl2.Text="0"; cboRechenArt.SelectedIndex = -1; txtErgebnis.Clear();
            
        }

        private void btnBeenden_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void txtZahl1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtZahl1.Text == "0")
            {
            txtZahl1.Text = "";
            }
        }

        private void txtZahl1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtZahl1.Text == "")
            {
            txtZahl1.Text = "0";
            }
        }

        private void txtZahl2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtZahl2.Text == "")
            {
            txtZahl2.Text = "0";
            }
        }

        private void txtZahl2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtZahl2.Text == "0")
            {
            txtZahl2.Text = "";
            }
        }
    }
}