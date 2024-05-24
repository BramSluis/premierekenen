namespace premierekenen
{
    partial class PremieRekenen
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            korting = new TextBox();
            textBox2 = new TextBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            listBox1 = new ListBox();
            panel2 = new Panel();
            listBox2 = new ListBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Regio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Korting%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 2;
            label3.Text = "Eigendomswaarde";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 90);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Verzekering";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Noord", "Midden", "Zuid" });
            comboBox1.Location = new Point(136, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(78, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // korting
            // 
            korting.Location = new Point(136, 35);
            korting.Name = "korting";
            korting.ReadOnly = true;
            korting.Size = new Size(78, 23);
            korting.TabIndex = 5;
            korting.Tag = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 60);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "De waarde van het eigendom";
            textBox2.Size = new Size(215, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 52);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(131, 19);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Inboedelverzekering";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 27);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(109, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Huisverzekering";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(12, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(111, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Autoverzekering";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(13, 182);
            button1.Name = "button1";
            button1.Size = new Size(339, 23);
            button1.TabIndex = 9;
            button1.Text = "Premie berekenen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(357, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(228, 199);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Location = new Point(136, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 74);
            panel2.TabIndex = 11;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Green;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Noord: 25% korting", "Midden: 10% korting", "Zuid: 15% korting" });
            listBox2.Location = new Point(220, 9);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(131, 49);
            listBox2.TabIndex = 12;
            listBox2.Visible = false;
            // 
            // PremieRekenen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 209);
            Controls.Add(listBox2);
            Controls.Add(panel2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(korting);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PremieRekenen";
            Text = "PremieRekenen";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox korting;
        private TextBox textBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private ListBox listBox1;
        private Panel panel2;
        private ListBox listBox2;
    }
}
