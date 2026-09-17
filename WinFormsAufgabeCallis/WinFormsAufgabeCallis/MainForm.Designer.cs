namespace WinFormsAufgabeCallis
{
    partial class MainForm
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
            comboBoxAnrede = new ComboBox();
            textBoxName = new TextBox();
            textBoxPostleitzahl = new TextBox();
            textBoxVorname = new TextBox();
            comboBoxKurs = new ComboBox();
            radioButtonBerechtigt = new RadioButton();
            buttonHinzufügen = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            radioButtonNichtBerechtigt = new RadioButton();
            radioButtonTeilweise = new RadioButton();
            listBoxTeilnehmer = new ListBox();
            labelRegistrieren = new Label();
            labelTeilnehmer = new Label();
            labelAnzahlTeilnehmer = new Label();
            SuspendLayout();
            // 
            // comboBoxAnrede
            // 
            comboBoxAnrede.FormattingEnabled = true;
            comboBoxAnrede.Location = new Point(145, 86);
            comboBoxAnrede.Name = "comboBoxAnrede";
            comboBoxAnrede.Size = new Size(121, 23);
            comboBoxAnrede.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(145, 126);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(121, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxPostleitzahl
            // 
            textBoxPostleitzahl.BorderStyle = BorderStyle.None;
            textBoxPostleitzahl.Location = new Point(145, 206);
            textBoxPostleitzahl.Name = "textBoxPostleitzahl";
            textBoxPostleitzahl.Size = new Size(121, 16);
            textBoxPostleitzahl.TabIndex = 2;
            // 
            // textBoxVorname
            // 
            textBoxVorname.Location = new Point(145, 166);
            textBoxVorname.Name = "textBoxVorname";
            textBoxVorname.Size = new Size(121, 23);
            textBoxVorname.TabIndex = 3;
            // 
            // comboBoxKurs
            // 
            comboBoxKurs.FormattingEnabled = true;
            comboBoxKurs.Location = new Point(145, 239);
            comboBoxKurs.Name = "comboBoxKurs";
            comboBoxKurs.Size = new Size(121, 23);
            comboBoxKurs.TabIndex = 4;
            // 
            // radioButtonBerechtigt
            // 
            radioButtonBerechtigt.AutoSize = true;
            radioButtonBerechtigt.Location = new Point(146, 277);
            radioButtonBerechtigt.Name = "radioButtonBerechtigt";
            radioButtonBerechtigt.Size = new Size(79, 19);
            radioButtonBerechtigt.TabIndex = 5;
            radioButtonBerechtigt.TabStop = true;
            radioButtonBerechtigt.Text = "berechtigt";
            radioButtonBerechtigt.UseVisualStyleBackColor = true;
            // 
            // buttonHinzufügen
            // 
            buttonHinzufügen.Cursor = Cursors.Hand;
            buttonHinzufügen.FlatStyle = FlatStyle.System;
            buttonHinzufügen.Location = new Point(177, 372);
            buttonHinzufügen.Name = "buttonHinzufügen";
            buttonHinzufügen.Size = new Size(89, 23);
            buttonHinzufügen.TabIndex = 6;
            buttonHinzufügen.Text = "Hinzufügen";
            buttonHinzufügen.UseVisualStyleBackColor = true;
            buttonHinzufügen.Click += buttonHinzufügen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 89);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 7;
            label1.Text = "Anrede";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 129);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 169);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 9;
            label3.Text = "Vorname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 209);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 10;
            label4.Text = "Postleitzahl";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 242);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 11;
            label5.Text = "Kurs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 277);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 12;
            label6.Text = "Vorsteuerabzug";
            // 
            // radioButtonNichtBerechtigt
            // 
            radioButtonNichtBerechtigt.AutoSize = true;
            radioButtonNichtBerechtigt.Location = new Point(145, 302);
            radioButtonNichtBerechtigt.Name = "radioButtonNichtBerechtigt";
            radioButtonNichtBerechtigt.Size = new Size(109, 19);
            radioButtonNichtBerechtigt.TabIndex = 13;
            radioButtonNichtBerechtigt.TabStop = true;
            radioButtonNichtBerechtigt.Text = "nicht berechtigt";
            radioButtonNichtBerechtigt.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeilweise
            // 
            radioButtonTeilweise.AutoSize = true;
            radioButtonTeilweise.Location = new Point(145, 327);
            radioButtonTeilweise.Name = "radioButtonTeilweise";
            radioButtonTeilweise.Size = new Size(70, 19);
            radioButtonTeilweise.TabIndex = 14;
            radioButtonTeilweise.TabStop = true;
            radioButtonTeilweise.Text = "teilweise";
            radioButtonTeilweise.UseVisualStyleBackColor = true;
            // 
            // listBoxTeilnehmer
            // 
            listBoxTeilnehmer.FormattingEnabled = true;
            listBoxTeilnehmer.Location = new Point(419, 36);
            listBoxTeilnehmer.Name = "listBoxTeilnehmer";
            listBoxTeilnehmer.Size = new Size(332, 379);
            listBoxTeilnehmer.TabIndex = 15;
            // 
            // labelRegistrieren
            // 
            labelRegistrieren.AutoSize = true;
            labelRegistrieren.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegistrieren.ForeColor = SystemColors.MenuHighlight;
            labelRegistrieren.Location = new Point(56, 22);
            labelRegistrieren.Name = "labelRegistrieren";
            labelRegistrieren.Size = new Size(152, 32);
            labelRegistrieren.TabIndex = 16;
            labelRegistrieren.Text = "Registrieren";
            labelRegistrieren.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTeilnehmer
            // 
            labelTeilnehmer.AutoSize = true;
            labelTeilnehmer.Location = new Point(347, 39);
            labelTeilnehmer.Name = "labelTeilnehmer";
            labelTeilnehmer.Size = new Size(66, 15);
            labelTeilnehmer.TabIndex = 17;
            labelTeilnehmer.Text = "Teilnehmer";
            // 
            // labelAnzahlTeilnehmer
            // 
            labelAnzahlTeilnehmer.AutoSize = true;
            labelAnzahlTeilnehmer.Location = new Point(419, 418);
            labelAnzahlTeilnehmer.Name = "labelAnzahlTeilnehmer";
            labelAnzahlTeilnehmer.Size = new Size(38, 15);
            labelAnzahlTeilnehmer.TabIndex = 18;
            labelAnzahlTeilnehmer.Text = "label7";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelAnzahlTeilnehmer);
            Controls.Add(labelTeilnehmer);
            Controls.Add(labelRegistrieren);
            Controls.Add(listBoxTeilnehmer);
            Controls.Add(radioButtonTeilweise);
            Controls.Add(radioButtonNichtBerechtigt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonHinzufügen);
            Controls.Add(radioButtonBerechtigt);
            Controls.Add(comboBoxKurs);
            Controls.Add(textBoxVorname);
            Controls.Add(textBoxPostleitzahl);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxAnrede);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teilnehmerliste";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAnrede;
        private TextBox textBoxName;
        private TextBox textBoxPostleitzahl;
        private TextBox textBoxVorname;
        private ComboBox comboBoxKurs;
        private RadioButton radioButtonBerechtigt;
        private Button buttonHinzufügen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton radioButtonNichtBerechtigt;
        private RadioButton radioButtonTeilweise;
        private ListBox listBoxTeilnehmer;
        private Label labelRegistrieren;
        private Label labelTeilnehmer;
        private Label labelAnzahlTeilnehmer;
    }
}
