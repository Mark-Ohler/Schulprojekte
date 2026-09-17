using System.Linq.Expressions;

namespace WinFormsRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstVerlauf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerlaufLöschen_Click(object sender, EventArgs e)
        {
            lstVerlauf.Items.Clear();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            try
            {
                double zahl1 = double.Parse(this.txtZahl1.Text);
                double zahl2 = double.Parse(txtZahl2.Text);
                double ergebnis = 0;



                switch (cboRechenart.Text)
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
                        MessageBox.Show($"Bitte wählen Sie einen Operator aus der Liste aus");
                        break;
                }
                txtErgebnis.Text = ergebnis.ToString();
                lstVerlauf.Items.Add($"{zahl1} {cboRechenart.Text} {zahl2} = {ergebnis}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte gültige Zahlen eingeben.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Division durch Null ist nicht erlaubt.");
            }
        }
    }
}

