namespace WinFormsFlächenFangen;

public partial class Form1 : Form
{
    private bool bButton = false;
    bool bPunktVergeben = false;
    Random r = new Random();
    int iAktuellerButton = 0;
    int punkestand = 0;
    int runde = 1;
    public Form1()
    {

        InitializeComponent();
        for (int i = 1; i <= 8; i++)
        {
            buttonAusschalten(i);
        }
    }

    private void buttonAusschalten(int nButton)
    {
        switch (nButton)
        {
            case 1:
                btn1.BackColor = Color.FromArgb(64, Color.Yellow);
                break;
            case 2:
                btn2.BackColor = Color.FromArgb(64, Color.Orange);
                break;
            case 3:
                btn3.BackColor = Color.FromArgb(64, Color.Red);
                break;
            case 4:
                btn4.BackColor = Color.FromArgb(64, Color.Purple);
                break;
            case 5:
                btn5.BackColor = Color.FromArgb(64, Color.Blue);
                break;
            case 6:
                btn6.BackColor = Color.FromArgb(64, Color.SteelBlue);
                break;
            case 7:
                btn7.BackColor = Color.FromArgb(64, Color.Cyan);
                break;
            case 8:
                btn8.BackColor = Color.FromArgb(64, Color.Green);
                break;
            default:
                listBox1.Items.Add("Fehler: falscher Button! " + nButton);
                break;
        }
    }
    public void buttonEinschalten(int nButton)
    {
        switch (nButton)
        {
            case 1:
                btn1.BackColor = Color.Yellow;
                break;
            case 2:
                btn2.BackColor = Color.Orange;
                break;
            case 3:
                btn3.BackColor = Color.Red;
                break;
            case 4:
                btn4.BackColor = Color.Purple;
                break;
            case 5:
                btn5.BackColor = Color.Blue;
                break;
            case 6:
                btn6.BackColor = Color.SteelBlue;
                break;
            case 7:
                btn7.BackColor = Color.Cyan;
                break;
            case 8:
                btn8.BackColor = Color.Green;
                break;
            default:
                listBox1.Items.Add("Fehler: falscher Button! " + nButton);
                break;
        }
    }

    private void label1_DoubleClick(object sender, EventArgs e)
    {
        if (bButton == false)
        {
            bButton = true;
            timer1.Enabled = true;
            lblMitte.Text = $"Spiel läuft...\nAktuell:\n{punkestand} Punkte";
        }
        else
        {
            for (int i = 1; i <= 8; i++)
            {
                buttonAusschalten(i);
            }
            bButton = false;
            iAktuellerButton = 0;
            timer1.Enabled = false;
            listBox1.Items.Add($"Partie {runde} beendet.");
            listBox1.Items.Add($"Erreichte Punkte: {punkestand}");
            lblMitte.Text = "Doppelklicken zum Starten. \r\nDoppelklicken zum \r\nBeenden";
            punkestand = 0;
            runde++;

        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        if (iAktuellerButton != 0)
        {
            buttonAusschalten(iAktuellerButton);
        }
        iAktuellerButton = r.Next(1, 9);
        buttonEinschalten(iAktuellerButton);
        bPunktVergeben = false;
    }
    private void clickAuswerten(int nButton)
    {
        if (nButton == iAktuellerButton && !bPunktVergeben)
        {
            punkestand++;
            lblMitte.Text = $"Spiel läuft...\nAktuell:\n{punkestand} Punkte";
            bPunktVergeben = true;
        }
    }

    private void btn1_Click(object sender, EventArgs e)
    {
        clickAuswerten(1);
    }

    private void btn2_Click(object sender, EventArgs e)
    {
        clickAuswerten(2);
    }

    private void btn3_Click(object sender, EventArgs e)
    {
        clickAuswerten(3);
    }

    private void btn4_Click(object sender, EventArgs e)
    {
        clickAuswerten(4);
    }

    private void btn5_Click(object sender, EventArgs e)
    {
        clickAuswerten(5);
    }

    private void btn6_Click(object sender, EventArgs e)
    {
        clickAuswerten(6);
    }

    private void btn7_Click(object sender, EventArgs e)
    {
        clickAuswerten(7);
    }

    private void btn8_Click(object sender, EventArgs e)
    {
        clickAuswerten(8);
    }
}

