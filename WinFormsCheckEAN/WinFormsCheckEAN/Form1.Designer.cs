namespace WinFormsCheckEAN
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
            label1 = new Label();
            cboEAN = new ComboBox();
            btnCheck1 = new Button();
            lblResult1 = new Label();
            txtEAN = new TextBox();
            label3 = new Label();
            lblResult2 = new Label();
            btnCheck2 = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(35, 166);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "EAN-Beispiele";
            // 
            // cboEAN
            // 
            cboEAN.Anchor = AnchorStyles.None;
            cboEAN.FormattingEnabled = true;
            cboEAN.Items.AddRange(new object[] { "4009350832398 ", "4009350832397", "400935083239" });
            cboEAN.Location = new Point(148, 167);
            cboEAN.Name = "cboEAN";
            cboEAN.Size = new Size(131, 23);
            cboEAN.TabIndex = 1;
            cboEAN.SelectedIndexChanged += cboEAN_SelectedIndexChanged;
            // 
            // btnCheck1
            // 
            btnCheck1.Anchor = AnchorStyles.None;
            btnCheck1.Location = new Point(301, 165);
            btnCheck1.Name = "btnCheck1";
            btnCheck1.Size = new Size(85, 24);
            btnCheck1.TabIndex = 2;
            btnCheck1.Text = "Check";
            btnCheck1.UseVisualStyleBackColor = true;
            btnCheck1.Click += btnCheck1_Click;
            // 
            // lblResult1
            // 
            lblResult1.Anchor = AnchorStyles.Right;
            lblResult1.AutoSize = true;
            lblResult1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult1.Location = new Point(423, 171);
            lblResult1.Name = "lblResult1";
            lblResult1.Size = new Size(113, 15);
            lblResult1.TabIndex = 3;
            lblResult1.Text = "Prüfung ausstehend";
            // 
            // txtEAN
            // 
            txtEAN.Anchor = AnchorStyles.None;
            txtEAN.BorderStyle = BorderStyle.FixedSingle;
            txtEAN.Location = new Point(148, 210);
            txtEAN.Name = "txtEAN";
            txtEAN.Size = new Size(131, 23);
            txtEAN.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(102, 208);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 5;
            label3.Text = "EAN";
            // 
            // lblResult2
            // 
            lblResult2.Anchor = AnchorStyles.Right;
            lblResult2.AutoSize = true;
            lblResult2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult2.Location = new Point(423, 219);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(113, 15);
            lblResult2.TabIndex = 6;
            lblResult2.Text = "Prüfung ausstehend";
            // 
            // btnCheck2
            // 
            btnCheck2.Anchor = AnchorStyles.None;
            btnCheck2.Location = new Point(301, 210);
            btnCheck2.Name = "btnCheck2";
            btnCheck2.Size = new Size(85, 24);
            btnCheck2.TabIndex = 7;
            btnCheck2.Text = "Check";
            btnCheck2.UseVisualStyleBackColor = true;
            btnCheck2.Click += btnCheck2_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Dock = DockStyle.Bottom;
            lblMessage.Location = new Point(0, 387);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(191, 15);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "Warten auf eingabe der ersten Zahl";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 402);
            Controls.Add(lblMessage);
            Controls.Add(btnCheck2);
            Controls.Add(lblResult2);
            Controls.Add(label3);
            Controls.Add(txtEAN);
            Controls.Add(lblResult1);
            Controls.Add(btnCheck1);
            Controls.Add(cboEAN);
            Controls.Add(label1);
            Name = "Form1";
            Text = "WindowsFormsCheckEAN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboEAN;
        private Button btnCheck1;
        private Label lblResult1;
        private TextBox txtEAN;
        private Label label3;
        private Label lblResult2;
        private Button btnCheck2;
        private Label lblMessage;
    }
}
