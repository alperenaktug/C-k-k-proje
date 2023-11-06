namespace Combobox_Listbox
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bursa ", "Ankara", "Balıkesir", "Gaziantep", "Elazığ", "Malatya", "İstanbul", "İzmir ", "Aydın" });
            comboBox1.Location = new Point(29, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 34);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(63, 104);
            button1.Name = "button1";
            button1.Size = new Size(159, 46);
            button1.TabIndex = 1;
            button1.Text = "Şehir Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 57);
            label1.Name = "label1";
            label1.Size = new Size(150, 26);
            label1.TabIndex = 3;
            label1.Text = "Şehir Ekle : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(460, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 34);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(476, 104);
            button3.Name = "button3";
            button3.Size = new Size(127, 44);
            button3.TabIndex = 5;
            button3.Text = "Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 26;
            listBox1.Items.AddRange(new object[] { "Öğretmen", "Doktor", "Mühendis", "Hemşire" });
            listBox1.Location = new Point(40, 259);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(224, 108);
            listBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(56, 397);
            button2.Name = "button2";
            button2.Size = new Size(166, 48);
            button2.TabIndex = 7;
            button2.Text = "Meslek Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(501, 352);
            button4.Name = "button4";
            button4.Size = new Size(150, 45);
            button4.TabIndex = 8;
            button4.Text = "Kaydet";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 315);
            label2.Name = "label2";
            label2.Size = new Size(105, 26);
            label2.TabIndex = 9;
            label2.Text = "Meslek :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(477, 312);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 34);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(1500, 585);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Arac Kullanimlari";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private ListBox listBox1;
        private Button button2;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
    }
}