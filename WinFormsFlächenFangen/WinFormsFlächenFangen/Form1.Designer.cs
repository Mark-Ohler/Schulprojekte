namespace WinFormsFlächenFangen
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn8 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            lblMitte = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Bottom;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 417);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(869, 94);
            listBox1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(btn8, 0, 1);
            tableLayoutPanel1.Controls.Add(btn3, 2, 0);
            tableLayoutPanel1.Controls.Add(btn2, 1, 0);
            tableLayoutPanel1.Controls.Add(btn1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn4, 2, 1);
            tableLayoutPanel1.Controls.Add(btn5, 2, 2);
            tableLayoutPanel1.Controls.Add(btn6, 1, 2);
            tableLayoutPanel1.Controls.Add(btn7, 0, 2);
            tableLayoutPanel1.Controls.Add(lblMitte, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(869, 417);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(3, 141);
            btn8.Name = "btn8";
            btn8.Size = new Size(283, 132);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(581, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(285, 132);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(292, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(283, 132);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(283, 132);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(581, 141);
            btn4.Name = "btn4";
            btn4.Size = new Size(285, 132);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(581, 279);
            btn5.Name = "btn5";
            btn5.Size = new Size(285, 135);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(292, 279);
            btn6.Name = "btn6";
            btn6.Size = new Size(283, 135);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(3, 279);
            btn7.Name = "btn7";
            btn7.Size = new Size(283, 135);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // lblMitte
            // 
            lblMitte.AutoSize = true;
            lblMitte.Dock = DockStyle.Fill;
            lblMitte.Location = new Point(292, 138);
            lblMitte.Name = "lblMitte";
            lblMitte.Size = new Size(283, 138);
            lblMitte.TabIndex = 8;
            lblMitte.Text = "Doppelklicken zum Starten. \r\nDoppelklicken zum \r\nBeenden";
            lblMitte.TextAlign = ContentAlignment.MiddleCenter;
            lblMitte.DoubleClick += label1_DoubleClick;
            // 
            // timer1
            // 
            timer1.Interval = 700;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 511);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn8;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Label lblMitte;
        private System.Windows.Forms.Timer timer1;
    }
}
