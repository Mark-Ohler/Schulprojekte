namespace WinFormsCheckEAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool EANCheck(string eingabe)
        {
            int result = 0;
            for (int i = 0; i < eingabe.Length; i++)
            {
                int ziffer = eingabe[i] - '0';
                if (i % 2 == 0)
                {
                    result += ziffer * 1;
                }
                else
                {
                    result += ziffer * 3;
                }
            }
            lblMessage.Text = $"gewichtete Quersumme: {result}";
            return result % 10 == 0;

        }


        private void btnCheck1_Click(object sender, EventArgs e)
        {
            string eingabe = cboEAN.Text;
            bool result = EANCheck(eingabe);
            if (result)
            {
                lblResult1.Text = "OK";
                lblResult1.ForeColor = Color.Green;
            }
            else
            {
                lblResult1.Text = "NOT OK";
                lblResult1.ForeColor = Color.Red;
            }
        }



        private void btnCheck2_Click(object sender, EventArgs e)
        {
            string eingabe = txtEAN.Text;
            if (eingabe.Length != 13)
            {
                lblResult2.Text = $"Invalid Length ({eingabe.Length})";
                lblResult2.ForeColor = Color.Red;
                lblResult2.Font = new Font(lblResult2.Font, FontStyle.Bold);
            }
            else
            {
                bool result = EANCheck(eingabe);

                if (result)
                {
                    lblResult2.Text = "OK";
                    lblResult2.ForeColor = Color.Green;
                    lblResult2.Font = new Font(lblResult2.Font, FontStyle.Bold);
                }
                else
                {
                    lblResult2.Text = "NOT OK";
                    lblResult2.ForeColor = Color.Red;
                    lblResult2.Font = new Font(lblResult2.Font, FontStyle.Bold);
                }
            }
        }

        private void cboEAN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
