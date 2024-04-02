namespace Exchange_API_Forms
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
            button_download = new Button();
            listBoxResponse = new ListBox();
            panel1 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            listBox2 = new ListBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label5 = new Label();
            comboBox2 = new ComboBox();
            listBox1 = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            button7 = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // button_download
            // 
            button_download.Location = new Point(632, 395);
            button_download.Name = "button_download";
            button_download.Size = new Size(133, 23);
            button_download.TabIndex = 0;
            button_download.Text = "Wyświetl wszystko";
            button_download.UseVisualStyleBackColor = true;
            button_download.Click += button_download_Click;
            // 
            // listBoxResponse
            // 
            listBoxResponse.FormattingEnabled = true;
            listBoxResponse.ItemHeight = 15;
            listBoxResponse.Location = new Point(577, 72);
            listBoxResponse.Name = "listBoxResponse";
            listBoxResponse.Size = new Size(211, 304);
            listBoxResponse.TabIndex = 1;
            listBoxResponse.SelectedIndexChanged += listBoxResponse_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 51);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 17);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 11;
            label4.Text = "Day: ";
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 378);
            panel3.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(3, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(138, 223);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 9;
            label3.Text = "Exchange rates";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ScrollBar;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(listBox1);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(comboBox1);
            panel4.Location = new Point(0, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(263, 399);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ScrollBar;
            panel5.Controls.Add(listBox2);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(comboBox2);
            panel5.Location = new Point(8, 8);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 399);
            panel5.TabIndex = 18;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(13, 196);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(216, 184);
            listBox2.TabIndex = 17;
            // 
            // button4
            // 
            button4.Location = new Point(120, 93);
            button4.Name = "button4";
            button4.Size = new Size(103, 48);
            button4.TabIndex = 16;
            button4.Text = "Usuń z porównywarki";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(12, 149);
            button5.Name = "button5";
            button5.Size = new Size(177, 23);
            button5.TabIndex = 15;
            button5.Text = "Wyświetl teraz";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(15, 93);
            button6.Name = "button6";
            button6.Size = new Size(99, 48);
            button6.TabIndex = 14;
            button6.Text = "Dodaj do porównywarki";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 24);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 11;
            label5.Text = "Wybierz walutę";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(15, 42);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(134, 23);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 254);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(216, 124);
            listBox1.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 101);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button3
            // 
            button3.Location = new Point(117, 140);
            button3.Name = "button3";
            button3.Size = new Size(103, 48);
            button3.TabIndex = 16;
            button3.Text = "Usuń z porównywarki";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 219);
            button2.Name = "button2";
            button2.Size = new Size(177, 23);
            button2.TabIndex = 15;
            button2.Text = "Wyświetl teraz";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 140);
            button1.Name = "button1";
            button1.Size = new Size(99, 48);
            button1.TabIndex = 14;
            button1.Text = "Dodaj do porównywarki";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 83);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 13;
            label2.Text = "Wybierz datę";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 24);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 11;
            label1.Text = "Wybierz walutę";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(450, 99);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 11;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(269, 100);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 12;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(374, 54);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 13;
            label6.Text = "Przelicz";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(272, 81);
            label7.Name = "label7";
            label7.Size = new Size(15, 15);
            label7.TabIndex = 14;
            label7.Text = "z:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(439, 81);
            label8.Name = "label8";
            label8.Size = new Size(23, 15);
            label8.TabIndex = 15;
            label8.Text = "na:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(272, 141);
            label9.Name = "label9";
            label9.Size = new Size(209, 15);
            label9.TabIndex = 17;
            label9.Text = "Podaj wartość, którą chcesz przeliczyć:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(439, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(439, 207);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 19;
            label10.Text = "Wynik:";
            // 
            // button7
            // 
            button7.Location = new Point(277, 225);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 20;
            button7.Text = "Oblicz";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(label10);
            Controls.Add(textBox2);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(listBoxResponse);
            Controls.Add(button_download);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_download;
        private ListBox listBoxResponse;
        private Panel panel1;
        private Label label3;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Panel panel5;
        private ListBox listBox2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox2;
        private Label label10;
        private Button button7;
        private Label label4;
    }
}
