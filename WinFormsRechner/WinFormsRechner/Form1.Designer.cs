namespace WinFormsRechner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            txtErgebnis = new TextBox();
            btnBeenden = new Button();
            label1 = new Label();
            btnVerlaufLöschen = new Button();
            label2 = new Label();
            btnBerechnen = new Button();
            label3 = new Label();
            label4 = new Label();
            txtZahl2 = new TextBox();
            txtZahl1 = new TextBox();
            cboRechenart = new ComboBox();
            lstVerlauf = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(txtErgebnis);
            panel1.Controls.Add(btnBeenden);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnVerlaufLöschen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnBerechnen);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtZahl2);
            panel1.Controls.Add(txtZahl1);
            panel1.Controls.Add(cboRechenart);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 326);
            panel1.TabIndex = 0;
            // 
            // txtErgebnis
            // 
            txtErgebnis.BorderStyle = BorderStyle.FixedSingle;
            txtErgebnis.Location = new Point(179, 186);
            txtErgebnis.Name = "txtErgebnis";
            txtErgebnis.Size = new Size(159, 23);
            txtErgebnis.TabIndex = 11;
            txtErgebnis.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBeenden
            // 
            btnBeenden.Location = new Point(379, 186);
            btnBeenden.Name = "btnBeenden";
            btnBeenden.Size = new Size(107, 23);
            btnBeenden.TabIndex = 3;
            btnBeenden.Text = "Beenden";
            btnBeenden.UseVisualStyleBackColor = true;
            btnBeenden.Click += btnBeenden_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 103);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Zahl 1:";
            // 
            // btnVerlaufLöschen
            // 
            btnVerlaufLöschen.Location = new Point(379, 155);
            btnVerlaufLöschen.Name = "btnVerlaufLöschen";
            btnVerlaufLöschen.Size = new Size(107, 23);
            btnVerlaufLöschen.TabIndex = 2;
            btnVerlaufLöschen.Text = "Verlauf löschen";
            btnVerlaufLöschen.UseVisualStyleBackColor = true;
            btnVerlaufLöschen.Click += btnVerlaufLöschen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 131);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Rechenart";
            label2.Click += label2_Click;
            // 
            // btnBerechnen
            // 
            btnBerechnen.Location = new Point(379, 123);
            btnBerechnen.Name = "btnBerechnen";
            btnBerechnen.Size = new Size(107, 23);
            btnBerechnen.TabIndex = 1;
            btnBerechnen.Text = "Berechnen";
            btnBerechnen.UseVisualStyleBackColor = true;
            btnBerechnen.Click += btnBerechnen_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 163);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Zahl 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 193);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Ergebnis:";
            // 
            // txtZahl2
            // 
            txtZahl2.BorderStyle = BorderStyle.FixedSingle;
            txtZahl2.Location = new Point(179, 156);
            txtZahl2.Name = "txtZahl2";
            txtZahl2.Size = new Size(159, 23);
            txtZahl2.TabIndex = 9;
            txtZahl2.TextAlign = HorizontalAlignment.Right;
            txtZahl2.TextChanged += textBox2_TextChanged;
            // 
            // txtZahl1
            // 
            txtZahl1.BorderStyle = BorderStyle.FixedSingle;
            txtZahl1.Location = new Point(179, 95);
            txtZahl1.Name = "txtZahl1";
            txtZahl1.Size = new Size(159, 23);
            txtZahl1.TabIndex = 10;
            txtZahl1.TextAlign = HorizontalAlignment.Right;
            // 
            // cboRechenart
            // 
            cboRechenart.FormattingEnabled = true;
            cboRechenart.Items.AddRange(new object[] { "+", "-", "*", "/", "%" });
            cboRechenart.Location = new Point(179, 127);
            cboRechenart.Name = "cboRechenart";
            cboRechenart.Size = new Size(159, 23);
            cboRechenart.TabIndex = 0;
            // 
            // lstVerlauf
            // 
            lstVerlauf.Dock = DockStyle.Fill;
            lstVerlauf.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstVerlauf.FormattingEnabled = true;
            lstVerlauf.Location = new Point(0, 326);
            lstVerlauf.Name = "lstVerlauf";
            lstVerlauf.Size = new Size(591, 105);
            lstVerlauf.TabIndex = 0;
            lstVerlauf.SelectedIndexChanged += lstVerlauf_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 431);
            Controls.Add(lstVerlauf);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinFormsRechner";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBerechnen;
        private Button btnVerlaufLöschen;
        private Button btnBeenden;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtZahl2;
        private ListBox lstVerlauf;
        private ComboBox cboRechenart;
        private TextBox txtErgebnis;
        private TextBox txtZahl1;
    }
}
